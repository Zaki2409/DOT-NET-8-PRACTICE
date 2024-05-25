using EmployeeMngt.Domain.Entities;
using EmployeeMngt.Infrastructure.Repository.EmployeeRepository;

namespace EmployeeMngt.Application.Services.EmployeeService
{
    public class EmployeeInterface : IEmployeeInterface
    {

        private readonly IEmployeeRepository _IEmployeeRepository;

        public EmployeeInterface(IEmployeeRepository employeeRepository)
        {
            _IEmployeeRepository = employeeRepository;
        }


        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await _IEmployeeRepository.AddAsync(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _IEmployeeRepository.GetAllEmployeesAsync();
        }
    }
}
