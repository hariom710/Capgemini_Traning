using Day_2_Dotnet_Core_Backend_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_2_Dotnet_Core_Backend_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private Day2Context context;

        public EmployeeController(Day2Context context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("GetEmployeeByDept/{dept}")]
        public IActionResult Get(string dept)
        {
            var employees = context.Employees.Where(e => e.Department == dept).ToList();
            if (employees == null || employees.Count == 0)
            {
                return NotFound("No employees found in this department");
            }
            return Ok(employees);
        }

        [HttpGet]
        [Route("GetHighestSalary")]
        public IActionResult GetHighestSalary()
        {
            var highestSalaryEmployee = context.Employees.OrderByDescending(e => e.Salary).FirstOrDefault();
            if (highestSalaryEmployee == null)
            {
                return NotFound("No employees found");
            }
            return Ok(highestSalaryEmployee);
        }
    }
}
