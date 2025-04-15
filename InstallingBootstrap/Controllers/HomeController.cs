using InstallingBootstrap.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstallingBootstrap.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {

            var student= new List<Student>{
                new Student{Id=1,Name="Sudhir",Gender="Male"},
                new Student{Id=1,Name="Amar",Gender="Male"},
                new Student{Id=1,Name="Kadir",Gender="Male"},
            };
            return View(student);
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
