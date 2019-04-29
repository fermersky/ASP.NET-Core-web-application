using Microsoft.AspNetCore.Mvc;
using web_application.Models;

namespace web_application.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {
            ViewBag.Employee = _employeeRepository.GetEmployee(2);
            return View();
        }
    }
}