using Day_4_Dotnet_Core_Backend_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_4_Dotnet_Core_Backend_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private MyDbContext context;

        public StudentController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("getStudents")]
        public IActionResult Get()
        {
            var students = context.Students.ToList();
            return Ok(students);
        }

        [HttpGet]
        [Route("getStudent/{id}")]
        public IActionResult Get(int id)
        {
            var student = context.Students.Find(id);
            if (student == null)
            {
                return NotFound("Student not found");
            }
            return Ok(student);
        }

        [HttpPost]
        [Route("addStudent")]
        public IActionResult Post(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return Ok("Student added successfully");
        }

        [HttpPut]
        [Route("updateStudent/{id}")]
        public IActionResult Put(int id,Student student)
        {
            var existingStudent = context.Students.Find(id);
            if (existingStudent == null)
            {
                return NotFound("Student not found");
            }

            existingStudent.Name = student.Name;
            existingStudent.Age = student.Age;

            context.SaveChanges();
            return Ok("Student updated successfully");
        }

        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            if (student == null)
            {
                return NotFound("Student not found");
            }
            context.Students.Remove(student);
            context.SaveChanges();
            return Ok("Student deleted successfully");
        }
    }
}