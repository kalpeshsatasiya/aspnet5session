using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Http;

namespace aspnet5session.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ///Set Session values
            HttpContext.Session.SetInt32("UserId", 1);
            HttpContext.Session.SetString("UserName", "Kalpesh");

            ///Get Session Values
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
