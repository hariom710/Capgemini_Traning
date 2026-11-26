using Day_1.Models;

namespace Day_1.Data
{
    public static class ProductRepository
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 75000 },
            new Product { Id = 2, Name = "Phone", Price = 25000 }
        };
    }
}
