using System.Collections.Generic;
using System.Linq;

namespace web_application.Models
{
    public class MockEmployeeRespoitory : IEmployeeRepository
    {
        private List<Employee> _empoyeeList;

        public MockEmployeeRespoitory()
        {
            _empoyeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Daniel", Email = "dynastytyan@gmail.com", Department = "IT" },
                new Employee() { Id = 2, Name = "Alina", Email = "alinatyan@gmail.com", Department = "IT" },
                new Employee() { Id = 3, Name = "Michael", Email = "shumah@gmail.com", Department = "F1" }
            };
        }
        public Employee GetEmployee(int id)
        {
            return _empoyeeList.Where(e => e.Id == id).FirstOrDefault();    
        }
    }
}