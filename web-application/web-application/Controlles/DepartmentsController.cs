using Microsoft.AspNetCore.Mvc;
using web_application.Models;
using web_application.ViewModels;

namespace web_application.Controllers
{
    public class DepartmentsController : Controller
    {
        public string List()
        {
            return "Hello from DepartmentsController, method List()";
        }
    }
}