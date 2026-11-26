using Day_1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(TodoRepository.Todos);
        }

        [HttpGet("completed")]
        public IActionResult GetCompleted()
        {
            var result = TodoRepository.Todos
                .Where(t => t.IsCompleted)
                .ToList();

            return Ok(result);
        }

        [HttpGet("pending")]
        public IActionResult GetPending()
        {
            var result = TodoRepository.Todos
                .Where(t => !t.IsCompleted)
                .ToList();

            return Ok(result);
        }

        [HttpPatch("{id}/complete")]
        public IActionResult MarkAsCompleted(int id)
        {
            var todo = TodoRepository.Todos.FirstOrDefault(t => t.Id == id);

            if (todo == null)
                return NotFound("Todo not found");

            if (todo.IsCompleted)
                return BadRequest("Already completed");

            todo.IsCompleted = true;

            return Ok(todo);
        }
    }
}
