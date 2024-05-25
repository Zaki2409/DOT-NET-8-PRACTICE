using EmployeeMngt.Application.Services.EmployeeService;
using EmployeeMngt.Domain.Entities;
using EmployeeMngt.Infrastructure.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMngt.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeInterface _employeeService;
        //Create a variable to hold the instance of GenericRepository
        private IGenericRepository<Employee> _genericRepository = null;

        public EmployeeController(IEmployeeInterface employeeService , IGenericRepository<Employee> genericRepository)
        {
            _employeeService = employeeService;
            _genericRepository = genericRepository;


        }
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            //var employees = await _employeeService.GetAllEmployeesAsync(); // Assuming you have a method to retrieve all employees
            //return Ok(employees);

            var employees = _genericRepository.GetAll();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {

            if (!ModelState.IsValid) { 
            return BadRequest(ModelState);
            }

            try
            {
                //var addedEmployee = await _employeeService.AddEmployeeAsync(employee);
                //return Ok(addedEmployee);
               var addedemp = _genericRepository.Insert(employee);
                _genericRepository

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add employee: {ex.Message}");
            }
        }

    }
}
