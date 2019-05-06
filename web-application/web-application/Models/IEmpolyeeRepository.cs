using System.Collections.Generic;

namespace web_application.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployes();
    }
}