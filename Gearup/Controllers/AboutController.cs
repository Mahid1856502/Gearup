using Microsoft.AspNetCore.Mvc;

namespace Gearup.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
