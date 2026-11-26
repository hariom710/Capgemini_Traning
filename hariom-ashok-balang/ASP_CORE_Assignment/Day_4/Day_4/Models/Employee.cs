using System.ComponentModel.DataAnnotations;

namespace Day_4_Dotnet_Core_Backend_Assignment.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [MinLength(3)]
        public string? Department { get; set; }
    }
}
