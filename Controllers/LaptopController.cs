using Microsoft.AspNetCore.Mvc;
using SD_115_F22SD_Assessment.Database;

namespace SD_115_F22SD_Assessment.Controllers
{
    public class LaptopController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = "All Laptops";
            return View(Context.Laptops);
        }
    }
}
