using Microsoft.AspNetCore.Mvc;
using Mission06_Griffin.Models;
using System.Diagnostics;

namespace Mission06_Griffin.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationsContext _context;
        public HomeController(MovieApplicationsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add", new Application());
        }

        [HttpPost]
        public IActionResult Add(Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
