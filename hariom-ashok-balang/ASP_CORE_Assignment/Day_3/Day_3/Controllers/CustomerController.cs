using Day_3.Models;
using Day_3.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Day_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomer repo;

        public CustomerController(ICustomer _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        [Route("GetCustomers")]
        public IActionResult Get()
        {

            var customers = repo.GetCust();
            return Ok(customers);
        }

        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult Post(Customer customer)
        {
            repo.AddCustomer(customer);
            return Ok("Customer added sucessfully");
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var customer = repo.GetById(id);
            if (customer == null)
            {
                return NotFound("Customer Not Found");
            }
            return Ok(customer);
        }

        [HttpPut]
        [Route("UpdateCustomer")]
        public IActionResult Put(Customer customer)
        {
            var data = repo.GetById(customer.Id);
            if (data == null)
            {
                return NotFound("Customer Not Found");
            }
            else
            {
                repo.UpdateCustomer(customer);
                return Ok("Customer updated sucessfully");
            }
        }

        [HttpDelete]
        [Route("DeleteCustomer/{id}")]
        public IActionResult DeleteById(int id)
        {
            var customer = repo.GetById(id);
            if (customer == null)
            {
                return NotFound("Customer Not Found");
            }
            else
            {
                repo.DeleteCustomer(id);
                return Ok("Customer deleted sucessfully");
            }
        }
    }
}
