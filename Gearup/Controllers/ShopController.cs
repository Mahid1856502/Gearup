using Microsoft.AspNetCore.Mvc;

namespace Gearup.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}
