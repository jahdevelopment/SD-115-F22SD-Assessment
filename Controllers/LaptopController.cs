using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SD_115_F22SD_Assessment.Database;
using SD_115_F22SD_Assessment.Models;
using SD_115_F22SD_Assessment.Models.ViewModels;
using System.Data;
using System.Drawing;
using System.Linq;

namespace SD_115_F22SD_Assessment.Controllers
{
    public class LaptopController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = "All Laptops";
            return View(Context.Laptops);
        }

        public IActionResult MostExpensive()
        {
            var laptops = Context.Laptops.OrderByDescending(l => l.Price).Take(2).ToList();
            return View(laptops);
        }


        public ActionResult MostAffordable()
        {
            var laptops = Context.Laptops.OrderBy(l => l.Price).Take(3).ToList();
            return View(laptops);
        }


        public IActionResult LaptopsByBusiness(string typeOfBusiness)
        {
            List<string> business = Enum.GetNames(typeof(TypeOfBusiness)).ToList();


            if (business.Contains(typeOfBusiness, StringComparer.OrdinalIgnoreCase))
            {
                HashSet<Laptop> laptopByBusiness = Context.Laptops.Where(l =>
                {
                    return l.TypeOfBusiness.ToString().Equals(typeOfBusiness, StringComparison.OrdinalIgnoreCase);
                }).ToHashSet();

                return View("LaptopsByBusiness", laptopByBusiness);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]

        public IActionResult CompareLaptops()
        {
            try
            {
                CreateCatalogueVM vm = new CreateCatalogueVM(Context.Laptops, Context.LaptopsCopy);
                
                return View(vm);
            }
            catch
            {
                return View("CompareLaptops");
            }

        }


    }
}
