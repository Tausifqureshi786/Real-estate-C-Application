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
    public partial class UserControlViewProperty : UserControl
    {

        List<Property> PropertyList = new List<Property>();

        List<Property> resList = new List<Property>();
        public UserControlViewProperty(List<Property> propList)
        {
            InitializeComponent();
            this.PropertyList = propList;
        }

        public IEnumerable<Property> filterLinq = null;
        private void UserControlViewProperty_Load(object sender, EventArgs e)
        {
        }

        private void filterLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            /* Select to Filter Property:
                Property Type
                No Of Bathrooms
                No Of Bedrooms
                Square footage
                Price
                Neighbourhood*/
            try
            {
                
                propGridView.DataSource = null;
                var propType = txtfilterValue.Text;
                if (filterComboBx.SelectedItem.ToString() == "Property Type")
                {
                  

                    this.filterLinq = from prop in PropertyList
                                      where prop.PropertyType.Contains(propType.ToString())
                                      select prop;
                }
                else if (filterComboBx.SelectedItem.ToString() == "No Of Bathrooms")
                { 
                    this.filterLinq = from prop in PropertyList
                                      where prop.NoOfBathrooms == Double.Parse(propType)
                                      select prop;
                }
                else if (filterComboBx.SelectedItem.ToString() == "No Of Bedrooms")
                {
                    this.filterLinq = from prop in PropertyList
                                      where prop.NoOfBedrooms == Double.Parse(propType)
                                      select prop;
                }
                else if (filterComboBx.SelectedItem.ToString() == "Square footage")
                {
                    this.filterLinq = from prop in PropertyList
                                      where prop.SquareFootage == Double.Parse(propType)
                                      select prop;
                }
                else if (filterComboBx.SelectedItem.ToString() == "Price")
                {
                    this.filterLinq = from prop in PropertyList
                                      where prop.ListingPrice == Double.Parse(propType)
                                      select prop;
                }
                else if (filterComboBx.SelectedItem.ToString() == "Neighbourhood")
                {
                    this.filterLinq = from prop in PropertyList
                                      where prop.Neighbourhood.Contains(propType.ToString())
                                      select prop;
                }
                


                txtfilterValue.Text = "";
                foreach (var prop in filterLinq)
                {
                    resList.Add(prop);
                }

                if (resList.Count != 0) {
                    propGridView.DataSource = this.resList;

                }


                txtfilterValue.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
