using SD_115_F22SD_Assessment.Database;

namespace SD_115_F22SD_Assessment.Models
{
    public class Brand
    {
        private int _brandId;

        public int BrandId { get { return _brandId; } }

        
        private string _brandName;

        public string BrandName
        {
            get { return _brandName; }

            set
            {
                if (value.Length > 1)
                {
                    _brandName = value;
                }
                else
                {
                    throw new Exception("Brand name must be at least Two characters long.");
                }
            }
        }

        private string _model;

        public string Model
        {
            get { return _model; }

            set
            {
                if (value.Length > 1)
                {
                    _model = value;
                }
                else
                {
                    throw new Exception("Model must be at least two characters long.");
                }
            }
        }

        public HashSet <Laptop> Laptops = new HashSet <Laptop> ();


        public Brand()
        {
            _brandId = Context.GetIdCount();
        }

        public Brand(string brandName, string model)
        {
            BrandName = brandName;

            Model = model;
        }
    }
}
