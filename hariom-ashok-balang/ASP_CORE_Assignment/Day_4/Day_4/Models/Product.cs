namespace Day_4_Dotnet_Core_Backend_Assignment.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

    }
}
