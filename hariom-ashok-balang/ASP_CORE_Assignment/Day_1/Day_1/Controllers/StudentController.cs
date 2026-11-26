using Day_1.Data;
using Day_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(StudentRepository.Students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = StudentRepository.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = StudentRepository.Students.Any()
                ? StudentRepository.Students.Max(s => s.Id) + 1
                : 1;

            StudentRepository.Students.Add(student);

            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Student updatedStudent)
        {
            var student = StudentRepository.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Course = updatedStudent.Course;

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = StudentRepository.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            StudentRepository.Students.Remove(student);

            return Ok("Student deleted");
        }

        [HttpGet("older-than-20")]
        public IActionResult GetOlderStudents()
        {
            var result = StudentRepository.Students
                .Where(s => s.Age > 20)
                .ToList();

            return Ok(result);
        }

        [HttpGet("search")]
        public IActionResult SearchByCourse([FromQuery] string course)
        {
            var result = StudentRepository.Students
                .Where(s => s.Course.ToLower() == course.ToLower())
                .ToList();

            return Ok(result);
        }
    }
}
