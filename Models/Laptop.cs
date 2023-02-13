using SD_115_F22SD_Assessment.Database;
using System.Security.Cryptography;


namespace SD_115_F22SD_Assessment.Models
{
    public class Laptop
    {
        private int _laptopId;

        public int LaptopId { get { return _laptopId; } }


        public Brand Brand { get; set; }

              
        public DateTime Year { get; set; }

        private int _quantity;

        public int Quantity { get { return _quantity; } }

        
        private int _price;

        public int Price { get { return _price;} }

        public TypeOfBusiness TypeOfBusiness { get; set; }


        public Laptop()
        {
            _laptopId = Context.GetIdCount();
        }

        public Laptop(Brand brand, DateTime year, int quantity, int price, TypeOfBusiness type)
        {
            Brand = brand;

            Year  = year;

            _quantity = quantity;

            _price = price;

            TypeOfBusiness = type;
        }
    }
}
