namespace Day_4_Dotnet_Core_Backend_Assignment.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Product>? Products { get; set; } 
    }
}
