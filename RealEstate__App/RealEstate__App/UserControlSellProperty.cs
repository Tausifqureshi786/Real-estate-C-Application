using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate__App
{
    public partial class UserControlSellProperty : UserControl
    {
        List<Property> propList = new List<Property>();

        public List<Property> resList = new List<Property>();

        Property foundProperty = new Property();


        IEnumerable<Property> findProperty = null;
        public UserControlSellProperty(List<Property> propertyList)
        {
            InitializeComponent();
            this.propList = propertyList;
        }

        private void btnGetProperty_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Double.Parse(txtPropID.Text);

               this.findProperty = from prop in propList
                                   where prop.PropertyID == id
                                   select prop;

                foreach(Property property in findProperty)
                {
                    this.resList.Add(property);
                    this.foundProperty = property;
                }

                if (foundProperty.imagePaths.Count != 0) {
                    propertyImageBox.Image = new Bitmap(foundProperty.imagePaths[0]);
                }

                if (foundProperty.PropertyID != 0 && foundProperty.ListingPrice!=0)
                {
                    txtPropID.Text = foundProperty.PropertyID.ToString();
                    txtPropName.Text = foundProperty.Name.ToString();
                    txtNeighbourhood.Text = foundProperty.Neighbourhood.ToString();
                    txtNoOfBath.Text = foundProperty.NoOfBathrooms.ToString();
                    txtNoOfBed.Text = foundProperty.NoOfBedrooms.ToString();
                    txtPropType.Text = foundProperty.PropertyType.ToString();
                    txtAddress.Text = foundProperty.Address.ToString();
                    txtSqFt.Text = foundProperty.SquareFootage.ToString();
                    txtLat.Text = foundProperty.Latitude.ToString();
                    txtLon.Text = foundProperty.Longitude.ToString();
                    txtListPrice.Text = foundProperty.ListingPrice.ToString();

                }



            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void propertyImageBox_Click(object sender, EventArgs e)
        {

        }

        private void txtLon_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSellProperty_Click(object sender, EventArgs e)
        {
            try
            {
                var soldTo = textBoxSoldTo.Text.ToString();

                var sellingPrice = txtSellingPrice.Text.ToString();

                this.foundProperty.RegisterProperty(Double.Parse(sellingPrice), soldTo, "Listed Removed");


                MessageBox.Show($"Congratulations to Mr./Ms/Mrs {soldTo} for purchasing the property for ${sellingPrice}");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);      
            }

        }
    }
}
