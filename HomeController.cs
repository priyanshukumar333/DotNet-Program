using System.Diagnostics;
using CurdOperation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace CurdOperation.Controllers
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
        public IActionResult ShowData(string nm, string ag, string gender, string ad, string ph, string email, string city, string pass)
        {
            ViewBag.Name = nm;
            ViewBag.Age = ag;
            ViewBag.Gender = gender;
            ViewBag.Address = ad;
            ViewBag.Phone = ph;
            ViewBag.Email = email;
            ViewBag.City = city;
            ViewBag.Password = pass;
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
