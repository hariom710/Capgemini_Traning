using Day_1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = ItemRepository.Items.Select(i => new
            {
                i.Id,
                i.Name,
                i.Quantity,
                Status = i.Quantity == 0 ? "Out of stock" : "Available"
            });

            return Ok(result);
        }

        [HttpPatch("{id}/reduce")]
        public IActionResult ReduceStock(int id, [FromQuery] int amount)
        {
            var item = ItemRepository.Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
                return NotFound("Item not found");

            if (amount <= 0)
                return BadRequest("Invalid amount");

            if (item.Quantity - amount < 0)
                return BadRequest("Not enough stock");

            item.Quantity -= amount;

            return Ok(item);
        }
    }
}
