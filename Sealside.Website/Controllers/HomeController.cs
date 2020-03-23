using Microsoft.AspNetCore.Mvc;

namespace Sealside.Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}