using Microsoft.AspNetCore.Mvc;
using apidemo.Models;

namespace apidemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeptController : ControllerBase
    {
        private readonly IDept repo;

        public DeptController(IDept repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("ListDepts")]
        public IActionResult ListDepts()
        {
            return Ok(repo.GetDepts());
        }

        [HttpGet]
        [Route("ListDepts/{id}")]
        public IActionResult Get(int id)
        {
            var dept = repo.FindDept(id);
            if (dept == null)
            {
                return NotFound();
            }
            return Ok(dept);
        }

        [HttpPost]
        public IActionResult AddDept(Dept dept)
        {
            var addedDept = repo.AddDept(dept);
            return CreatedAtAction(nameof(Get), new { id = addedDept.Id }, addedDept);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDept(int id, Dept dept)
        {
            if (id != dept.Id)
            {
                return BadRequest();
            }

            var updatedDept = repo.EditDept(dept);
            if (updatedDept == null)
            {
                return NotFound();
            }

            return Ok(updatedDept);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDept(int id)
        {
            var deletedDept = repo.DeleteDept(id);
            if (deletedDept == null)
            {
                return NotFound();
            }

            return Ok(deletedDept);
        }
    }
}
