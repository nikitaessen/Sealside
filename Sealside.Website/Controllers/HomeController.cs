using Microsoft.AspNetCore.Mvc;
using Sealside.Models.Database;

namespace Sealside.Website.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}