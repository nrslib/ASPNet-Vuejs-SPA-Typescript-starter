using Microsoft.AspNetCore.Mvc;

namespace VueWithTypescript.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
