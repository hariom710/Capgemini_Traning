namespace Day_4_Dotnet_Core_Backend_Assignment.Models
{
    public class Course
    {
        public int Id { get; set; } 

        public string? Title { get; set; }

        public List<StudentCourse>? StudentCourses { get; set; }
    }
}
