using Action_Results_Examples_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Action_Results_Examples_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Partial()
        {
            return PartialView();
        }

        public IActionResult Json()
        {
            var data = new { texnoName = "Dell" };
            return Json(data);

        }

        public IActionResult Redirect()
        {
            return Redirect("https://github.com/OrxanMehdizade");

        }

        public ActionResult Content()
        {
            return Content("ASUS");
        }

        public ActionResult Empty()
        {
            return new EmptyResult();
        }

        public ActionResult File()
        {
            return File("~/HtmlFile/file.html", "text/html");

        }

        public ActionResult Redirectroute()
        {
            return RedirectToRoute(new { controller = "Home", action = "Route" });

        }

        public ActionResult Route()
        {
            return View();
        }

        public IActionResult Privacy()
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