using System.Runtime.InteropServices;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        Employee IEmployeeRepository.GetEmployee(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}