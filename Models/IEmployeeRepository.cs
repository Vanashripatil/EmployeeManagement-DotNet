using System.Runtime.InteropServices;


namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}