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
    public partial class AgentForm : Form
    {
       readonly List<Property> PropertyList = new List<Property>();
        public AgentForm(List<Property> BrokerPropertyList)
        {
            InitializeComponent();
            this.PropertyList = BrokerPropertyList;

        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            menuPanel.AutoScroll = true;
        }

        private void btnLogoutAgent_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnViewProperty_Click(object sender, EventArgs e)
        {

            try
            {
                if (menuPanel.Controls != null)
                {
                    menuPanel.Controls.Clear();
                    dataGridView1.Show();
                    dataGridView1.DataSource = this.PropertyList;
                    menuPanel.Controls.Add(dataGridView1);


                }
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {

            try
            {
                if (menuPanel.Controls != null) {
                    menuPanel.Controls.Clear();
                    UserControlViewProperty viewPropertyControl = new UserControlViewProperty(PropertyList);
                    dataGridView1.Hide();
                    menuPanel.Controls.Add(viewPropertyControl);

                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnSellProperty_Click(object sender, EventArgs e)
        {
            try
            {

                if (menuPanel.Controls != null)
                {

                    menuPanel.Controls.Clear();

                    UserControlSellProperty sellProp = new UserControlSellProperty(PropertyList);

                    menuPanel.Controls.Add(sellProp);
                }



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
