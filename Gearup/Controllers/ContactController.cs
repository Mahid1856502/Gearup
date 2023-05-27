using Microsoft.AspNetCore.Mvc;

namespace Gearup.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index(string? name)
        {
            Console.WriteLine(name);
            return View();
        }
    }
}
