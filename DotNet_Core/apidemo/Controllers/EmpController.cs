using System.Reflection.Metadata.Ecma335;
using apidemo.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpController : ControllerBase
    {
        AprdbContext context = new AprdbContext();
        [HttpGet]
        [Route("ListEmp")]
        public IActionResult ListEmp()
        {
            var data = context.Emps.ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("ListEmp/{id}")]
        public IActionResult Get(int? id)
        {
            if (id == null)
            {
                return BadRequest("Invalid ID");
            }
            var data = (from e in context.Emps where e.Id == id select e).FirstOrDefault();
            if (data == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("AddEmp")]
        public IActionResult Post(Emp emp)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Emps.Add(emp);
                    context.SaveChanges();
                    return Created("Employee added successfully", emp);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.InnerException?.Message ?? ex.Message);
                }

            }
            else
            {
                return BadRequest("Invalid data");
            }



        }

        [HttpPut]
        [Route("UpdateEmp")]
        public IActionResult Put(int? id, Emp emp)
        {
            if (id == null || id != emp.Id)
            {
                return BadRequest("Invalid ID"); 
            }
            var existingEmp = (from e in context.Emps where e.Id == id select e).FirstOrDefault();
            if (existingEmp == null)
            {
                return NotFound("Employee id {id} not found");
            }
            existingEmp.Name = emp.Name;
            existingEmp.Email = emp.Email;
            existingEmp.DeptId = emp.DeptId;
            context.Emps.Update(existingEmp);
            context.SaveChanges();
            return Ok("Employee updated successfully");

        }

        [HttpDelete]
        [Route("DeleteEmp/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Invalid ID");
            }

            var data = context.Emps.Find(id);
            if (data == null)
            {
                return NotFound("Employee not found");
            }

            context.Emps.Remove(data);
            context.SaveChanges();
            return Ok("Employee deleted successfully");
        }

    }
}