using EmployeeMngt.Domain.Entities;
using EmployeeMngt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMngt.Infrastructure.Repository.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Employee> AddAsync(Employee employee)
        {
           //throw new NotImplementedException();
           _dbContext.Employee.Add(employee);
            await _dbContext.SaveChangesAsync();    
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _dbContext.Employee.ToListAsync();
        }
    }
}
