using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        private static List<string> fruits = new List<string>
        {
            "Apple","Banana","Mango","Cherry","Pineapple"
        };

        // GET: api/fruits
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return Ok(fruits);
        }

        // GET: api/fruits/2
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id < 0 || id >= fruits.Count)
                return NotFound("Fruit Not Found");

            return Ok(fruits[id]);
        }

        // POST: api/fruits
        [HttpPost]
        public ActionResult Add([FromBody] string fruit)
        {
            if (string.IsNullOrWhiteSpace(fruit))
                return BadRequest("Fruit name cannot be empty");

            fruits.Add(fruit);
            return Ok("Fruit Added Successfully");
        }

        // PUT: api/fruits/2
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] string fruit)
        {
            if (id < 0 || id >= fruits.Count)
                return NotFound("Fruit Not Found");

            if (string.IsNullOrWhiteSpace(fruit))
                return BadRequest("Fruit name cannot be empty");

            fruits[id] = fruit;
            return Ok("Fruit Updated Successfully");
        }

        // DELETE: api/fruits/2
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= fruits.Count)
                return NotFound("Fruit Not Found");

            fruits.RemoveAt(id);
            return Ok("Fruit Deleted Successfully");
        }
    }
}