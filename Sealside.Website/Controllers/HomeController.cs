using Microsoft.AspNetCore.Mvc;
using Sealside.Models.Database;
using Sealside.Crosscutting;

namespace Sealside.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDbContext _context;

        public HomeController(UserDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            SampleData.Initialize(_context);
            var users = _context.GetUsers();
            return View(users);
        }
    }
}