using EmployeeMngt.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace EmployeeMngt.Infrastructure.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
            public DbSet<Employee> Employee { get; set; }
            
            public DbSet<Address> Address { get; set; }

            public DbSet<Department> Department { get; set; }   

    }

}
