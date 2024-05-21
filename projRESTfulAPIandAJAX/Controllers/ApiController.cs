using Microsoft.AspNetCore.Mvc;
using projRESTfulAPIandAJAX.Models;
using System.Text;

namespace projRESTfulAPIandAJAX.Controllers
{
    public class ApiController : Controller
    {
        private readonly MyDbContext _dbContext;

        public ApiController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReturnContent()
        {
            System.Threading.Thread.Sleep(3000);
            return Content("Hello Fetch!!", "text/plain", Encoding.UTF8);
        }
        public IActionResult ReturnJson()
        {
            var categories = _dbContext.Categories.ToList();
            return Json(categories);
        }
        public IActionResult ReturnImage(int? id = 1)
        {
            Member? member = _dbContext.Members.Find(id);
            if (member == null)
                return NotFound();
            byte[]? img = member.FileData;
            return File(img, "image/jpeg");
        }
    }

}
