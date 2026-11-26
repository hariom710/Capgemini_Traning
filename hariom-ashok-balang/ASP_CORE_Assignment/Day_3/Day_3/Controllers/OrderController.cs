using Day_3.Models;
using Day_3.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrder repo;

        public OrderController(IOrder _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        [Route("GetOrders")]
        public IActionResult Get() {

            var orders = repo.GetOrders();
            return Ok(orders);
        }

        [HttpPost]
        [Route("AddOrder")]
        public IActionResult Post(Order order)
        {
            repo.AddOrder(order);
            return Ok("Order added sucessfully");
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var order = repo.GetById(id);
            if (order == null)
            {
                return NotFound("Order Not Found");
            }
            return Ok(order);
        }

        [HttpPut]
        [Route("UpdateOrder")]
        public IActionResult Put(Order order)
        {
            var data = repo.GetById(order.Id);
            if (data == null)
            {
                return NotFound("Order Not Found");
            }
            else
            {
                repo.UpdateOrder(order);
                return Ok("Order updated sucessfully");
            }
        }

        [HttpDelete]
        [Route("DeleteOrder/{id}")]
        public IActionResult DeleteById(int id)
        {
            var order = repo.GetById(id);
            if (order == null)
            {
                return NotFound("Order Not Found");
            }
            else
            {
                repo.DeleteOrder(id);
                return Ok("Order deleted sucessfully");
            }
        }
    }
}
