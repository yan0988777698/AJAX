using Microsoft.AspNetCore.Mvc;
using projRESTfulAPIandAJAX.Models;

namespace projRESTfulAPIandAJAX.Controllers
{
    public class HomeworkController : Controller
    {
        private readonly MyDbContext _db;
        public HomeworkController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult Travel()
        {
            return View();
        }
        public IActionResult Zip()
        {
            return View();
        }
    }
}
