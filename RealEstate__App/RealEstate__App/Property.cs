using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate__App
{
    public class Property
    {


        /* COMMERCIAL, RESIDENTIAL, INDUSTRIAL, LAND */
        public int PropertyID { get; set; }
        public string PropertyType { get; set; }
        public string Neighbourhood { get; set; }
        public string Address { get; set; }
        public double NoOfBedrooms { get; set; }
        public double NoOfBathrooms { get; set; }
        public double SquareFootage { get; set; }
        public double ListingPrice { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public string Name { get; set; }
        public double SellingPrice { get; set; }
        public string SoldTo { get; set; }
        public string ListingStatus { get; set; } = "Listed";

        public List<string> imagePaths = new List<string>();

        public Property()
        {
        }

        public Property(string name,int propId, double bed, double bath, string address, string neighbourhood, double lat, double lon, double price, double sqFoot, string type)
        {
            Name = name;
            PropertyID = propId;
            NoOfBedrooms = bed;
            NoOfBathrooms = bath;
            Address = address;
            Neighbourhood = neighbourhood;
            Latitude = lat;
            Longitude = lon;
            ListingPrice = price;
            SquareFootage = sqFoot;
            PropertyType = type;
        }

        public void RegisterProperty(double sellPrice, string buyer, string status)
        {
            SellingPrice = sellPrice;
            SoldTo = buyer;
            ListingStatus = status;
        }
        
    }
}
