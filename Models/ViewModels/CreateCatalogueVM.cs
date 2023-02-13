using Microsoft.AspNetCore.Mvc.Rendering;

namespace SD_115_F22SD_Assessment.Models.ViewModels
{
    public class CreateCatalogueVM
    {
        public List<SelectListItem> Laptops { get; } = new List<SelectListItem>();
        public List<SelectListItem> LaptopsCopy { get; } = new List<SelectListItem>();



        public CreateCatalogueVM(HashSet<Laptop> laptops, HashSet<Laptop> laptopsCopy)
        {
            foreach (Laptop l in laptops)
            {
                Laptops.Add(new SelectListItem(l.Brand.BrandName , l.LaptopId.ToString()));
            }

            foreach (Laptop b in laptopsCopy)
            {
                LaptopsCopy.Add(new SelectListItem(b.Brand.BrandName , b.LaptopId.ToString()));
            }
        }

        public CreateCatalogueVM() { }

    }
}
