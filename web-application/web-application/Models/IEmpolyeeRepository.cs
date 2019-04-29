namespace web_application.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}