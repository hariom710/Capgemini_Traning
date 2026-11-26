using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext context;

        public ProductRepo(AppDbContext context)
        {
            this.context = context;
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }

        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            var existing = context.Products.Find(product.Id);

            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Category = product.Category;

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var product = context.Products.Find(id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
