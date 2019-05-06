using Microsoft.AspNetCore.Mvc;
using web_application.Models;
using web_application.ViewModels;

namespace web_application.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("")]
        [Route("Index")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployes();
            return View(model);
        }

        [Route("Details/{id?}")]
        public ViewResult Details(int? id)
        {
            var viewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee details"
            };

            ViewBag.Employee = _employeeRepository.GetEmployee(id ?? 1);
            return View(viewModel);
        }
    }
}