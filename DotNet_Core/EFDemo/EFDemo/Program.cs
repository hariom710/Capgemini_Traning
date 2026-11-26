using EFDemo.Models;
using Microsoft.EntityFrameworkCore;


namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ListProducts();
            ListCategories();

        }

        //private static void ListProducts()  
        //{
        //    NorthwindContext context = new NorthwindContext();
        //    var products = context.Products.Include(p=>p.Category).ToList(); 
        //    foreach (var product in products)
        //    {
        //        Console.WriteLine($"{product.ProductId}: {product.ProductName} {product.UnitPrice}");
        //    }
        //}
        private static void ListCategories()
        {
            NorthwindContext context = new NorthwindContext();
            var categories = context.Categories.Include(c => c.Products).ToList();
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryId}: {category.CategoryName}");
                foreach (var product in category.Products)
                {
                    Console.WriteLine($"\t{product.ProductId}: {product.ProductName} {product.UnitPrice}");
                }
                Console.WriteLine("================================");
            }
        }
    }
}
