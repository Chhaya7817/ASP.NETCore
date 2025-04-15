using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInMVC.Models;
using ModelsInMVC.Repository;

namespace ModelsInMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeRepository _employeeRepository;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _employeeRepository = new EmployeeRepository();


        }

        public  List<EmployeeModel> getAllEmployees()
        {
            return _employeeRepository.getAllEmployees();
        }
        public EmployeeModel GetebyID(int ID)
        {
            return _employeeRepository.getEmployeeById(ID);
        }

        public IActionResult Index()
        {
            //var employees = new List<EmployeeModel>
            //{
            //    new EmployeeModel { Id=1,Name= "Rajesh" ,Age=25,Salary=2300 },
            //    new EmployeeModel { Id=2,Name= "Sohan" ,Age=25,Salary=2300 },
            //    new EmployeeModel { Id=3,Name= "Somana" ,Age=25,Salary=2300 },
            //    new EmployeeModel { Id=4,Name= "rinki" ,Age=25,Salary=2300 },
            //};
            //ViewData["myEmp"] = employees;

            
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
