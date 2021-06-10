using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using Newtonsoft.Json;
using System.Net.Http;



namespace RealEstate__App
{
    public partial class Form1 : Form
    {
        private string brokerUser = "broker";

        private string brokerPass = "broker123";

        private string agentUser = "agent";

        private string agentPass = "agent123";

        private string currentUser = "";

        private bool loginStatus = false;

         List<Property> PropertyList = new List<Property>();

        public void SetProperty(List<Property> propList)
        {
            PropertyList = propList;
        }


        public Form1()
        {
            InitializeComponent();

            PropertyList.Add(new Property("",1, 2, 2, "302 Skyview Ranch Dr NE, Calgary, AB T3N 0P5", "Skyview", 51.1592192394565, -113.96135947287398, 240000, 800, "Residential"));
            PropertyList.Add(new Property("",2, 2, 1.5, "303 Skyview Ranch Dr NE, Calgary, AB T3N 0P5", "Skyview", 51.158741180809066, -113.96179043131215, 240000, 800, "Residential"));
            PropertyList.Add(new Property("", 3, 3, 3, "168 Red Embers Pl NE, Calgary, AB T3N 1V5", "Redstone", 51.171047304784175, -113.9479275689591, 240000, 1400, "Residential"));
            PropertyList.Add(new Property("", 4, 2, 2, "168 Red Embers Pl NE, Calgary, AB T3N 1V5", "Redstone", 51.171047304784175, -113.9479275689591, 240000, 800, "Residential"));
            PropertyList.Add(new Property("", 5, 4, 3, "305 Skyview Ranch Dr NE", "Skyview", 51.158741180809066, -113.96179043131215, 240000, 800, "Residential"));
            PropertyList.Add(new Property("", 6, 2, 2, "303 Skyview Ranch Dr NE", "Skyview", 51.158741180809066, -113.96179043131215, 240000, 1100, "Residential"));
            PropertyList.Add(new Property("", 7, 2, 2, "402 Cement Factory Horizon Street", "Horizon", 51.158741180809066, -113.96179043131215, 240000, 1100, "Industrial"));



            BrokerBox.Hide();
            AddPropertyBox.Hide();
            btnLogout.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtUsername.Text == brokerUser && txtPassword.Text == brokerPass)
                {
                    //BrokerForm brokerForm = new BrokerForm();
                    //brokerForm.ShowDialog();
                    currentUser = "broker";
                    this.loginStatus = true;

                    // hide the userid and password textboxes
                    panel1.Hide();

                    
                    BrokerBox.Show();
                    btnLogout.Show();
                    btnLogin.Hide();
                    txtPassword.Text = "";
                    txtUsername.Text ="";

                }

                else if (txtUsername.Text == agentUser && txtPassword.Text == agentPass )
                {
                    //AgentForm agentForm = new AgentForm();
                    //agentForm.ShowDialog();
                    currentUser = "agent";
                    panel1.Hide();
                    BrokerBox.Hide();
                    

                    this.Hide();
                    AgentForm agent = new AgentForm( PropertyList);
                    agent.FormClosing += delegate { this.Show(); panel1.Show(); };
                    agent.ShowDialog();
                    

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                currentUser = "";
                BrokerBox.Hide();
                panel1.Show();
                btnLogin.Show();
                btnLogout.Hide();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = agentUser;
            txtPassword.Text = agentPass;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPropertyBox.Show();

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {

                if (imageOpenFIleDialog.ShowDialog() == DialogResult.OK)
                {
                    txtImage.Text = imageOpenFIleDialog.FileName;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void addPropertyButton_Click(object sender, EventArgs e)
        {

            try
            {
                var findProp = from prop in PropertyList
                               where prop.PropertyID.Equals(Convert.ToInt32(txtPropId.Text))
                               select prop;

                if (PropertyList.Exists(x => x.PropertyID == Convert.ToInt32(txtPropId.Text)) == false)
                {


                    Property newOne = new Property(txtPropName.Text.ToString(),Convert.ToInt32(txtPropId.Text), Convert.ToDouble(txtNoOfBed.Text),
                    Convert.ToDouble(txtNoOfBath.Text), txtAddress.Text, txtNeighbourhood.Text, Convert.ToDouble(txtLat.Text),
                    Convert.ToDouble(txtLon.Text), Convert.ToDouble(txtListPrice.Text), Convert.ToDouble(txtSqFt.Text),
                    txtPropType.Text);

                    PropertyList.Add(newOne);

                    MessageBox.Show($"Property Added Successfully.");

                }
                else
                {
                    MessageBox.Show("A property with the given id already exists please enter a new ID ");
                }


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        HttpClient client = new HttpClient();

        private string response { get; set; }
        private async Task GetAddress(string address) {
            this.response = await client.GetStringAsync(address);
           // MessageBox.Show(response);
        }

      
        private async void  btnGetAddress_Click(object sender, EventArgs e)
        {
            //var apiKey = "AIzaSyCzSFAsF5PVras0M9jH_PmGUnwhBFEN_II";

            try
            {

                
                var lat = Double.Parse(txtLat.Text);
                var lon = Double.Parse(txtLon.Text);
             
                var address = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={lat.ToString()},{lon.ToString()}&key=AIzaSyCzSFAsF5PVras0M9jH_PmGUnwhBFEN_II";

                await GetAddress(address);
            

                var jsonObject = Newtonsoft.Json.Linq.JObject.Parse(this.response);

                var LocationAddress = jsonObject["results"][0]["formatted_address"].ToString();

                //MessageBox.Show(jsonObject["results"][0]["formatted_address"].ToString());

                MessageBox.Show(LocationAddress);
                txtAddress.Text = LocationAddress;
            }
            catch (Exception err) { 
                MessageBox.Show(err.Message);
            }

        }

        private void gMap_Load(object sender, EventArgs e)
        {

        }

        private void BrokerBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
