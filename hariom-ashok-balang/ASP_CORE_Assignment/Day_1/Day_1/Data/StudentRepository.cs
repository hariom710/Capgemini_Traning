using Day_1.Models;

namespace Day_1.Data
{
    public class StudentRepository
    {
        public static List<Student> Students = new List<Student>
        {
            new Student { Id = 1, Name = "Rahul", Age = 22, Course = "CSE" },
            new Student { Id = 2, Name = "Amit", Age = 19, Course = "IT" },
            new Student { Id = 3, Name = "Sneha", Age = 21, Course = "CSE" },
            new Student { Id = 4, Name = "Priya", Age = 18, Course = "ECE" }
        };
    }
}
