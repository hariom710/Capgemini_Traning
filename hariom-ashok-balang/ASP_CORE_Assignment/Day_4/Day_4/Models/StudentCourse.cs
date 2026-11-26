namespace Day_4_Dotnet_Core_Backend_Assignment.Models
{
    public class StudentCourse
    {
        public int StudentId { get; set; }

        public Student? Student { get; set; }

        public int CourseId { get; set; }

        public Course? Course { get; set; }
    }
}
