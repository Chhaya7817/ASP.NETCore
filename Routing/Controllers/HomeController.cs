using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    [Route("[Controller]")]
    public class HomeController : Controller
    {

        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Details")]
        public int Details(int  id)
        {
            return id;
        }

        
    }
}
