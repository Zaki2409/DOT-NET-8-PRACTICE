using EmployeeMngt.Domain.Entities;

namespace EmployeeMngt.Application.Services.EmployeeService
{
    public interface IEmployeeInterface

    {
        Task<Employee> AddEmployeeAsync(Employee employee);


        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    }
}
