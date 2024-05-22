using Microsoft.AspNetCore.Mvc;
using projRESTfulAPIandAJAX.Models;
using projRESTfulAPIandAJAX.ViewModels;
using System.Collections;
using System.Net;
using System.Text;
using System.Xml.Linq;

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
            var cities = _dbContext.Addresses.Select(x => x.City).Distinct();
            return Json(cities);
        }
        public IActionResult Register(CRegisterViewModel mv)
        {
            return Content($"Hello {mv.name}, {mv.age}歲了, 電子郵件是{mv.email}", "text/plain", Encoding.UTF8);
        }
        public IActionResult ReturnImage(int? id = 1)
        {
            Member? member = _dbContext.Members.Find(id);
            if (member == null)
                return NotFound();
            byte[]? img = member.FileData;
            return File(img, "image/jpeg");
        }
        //取得不重複縣市名稱
        public IActionResult GetCity()
        {
            var cities = _dbContext.Addresses.Select(x => x.City).Distinct();
            return Json(cities);
        }
        //依據選擇的縣市，取得不重複鄉鎮區
        public IActionResult GetDistinction(string city)
        {
            var distinctions = _dbContext.Addresses.Where(x => x.City.Equals(city)).Select(x => x.SiteId).Distinct();
            return Json(distinctions);
        }
        //依據選擇的縣市及鄉鎮區，取得路名
        public IActionResult GetRoad(string distinction)
        {
            var roads = _dbContext.Addresses.Where(x => x.SiteId.Equals(distinction)).Select(x => x.Road);
            return Json(roads);
        }
    }
}
