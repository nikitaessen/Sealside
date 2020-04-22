using Microsoft.AspNetCore.Mvc;

namespace Sealside.Website.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        [Route("/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Register(string login, string password)
        {
            return Content($"User {login} registered");
        }
    }
}