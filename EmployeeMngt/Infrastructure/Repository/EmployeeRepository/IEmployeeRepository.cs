using EmployeeMngt.Domain.Entities;

namespace EmployeeMngt.Infrastructure.Repository.EmployeeRepository
{
    public interface IEmployeeRepository
    {

        Task<Employee> AddAsync(Employee employee);

        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    }
}
