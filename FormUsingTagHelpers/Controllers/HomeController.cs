using System.Diagnostics;
using FormUsingTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormUsingTagHelpers.Controllers
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
        [HttpPost]
        public IActionResult Index(Doctors d)
        {
            //if (ModelState.IsValid)
            //{
            //    return "Id: " + d.ID + "Name: " + d.Name + "Department: " + d.Department + "Salary: " + d.Salary + "Gender: " + d.Gender + "Description: " + d.Department + "Married: " + d.Married;

            //}
            //else
            //    return "Validation failed";
            return View();
        }
        public string Details(int id,string name)
        {
            return "Id is" + id + "Name is: " + name;
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
