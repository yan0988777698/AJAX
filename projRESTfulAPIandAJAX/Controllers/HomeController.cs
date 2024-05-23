using Microsoft.AspNetCore.Mvc;
using projRESTfulAPIandAJAX.Models;
using System.Diagnostics;
using System.Text;

namespace projRESTfulAPIandAJAX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, MyDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CategoryList()
        {
            return View(_dbContext.Categories);
        }

        public IActionResult FirstAjax()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Spot()
        {
            return View();
        }
        public IActionResult Api()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}