using Day_2_Dotnet_Core_Backend_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_2_Dotnet_Core_Backend_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private Day2Context context;

        public ProductController(Day2Context _context)
        {
            context = _context;
        }

        [HttpGet]
        [Route("GetProducts")]
        public IActionResult Get()
        {
            return Ok(context.Products.ToList());
        }

        [HttpGet]
        [Route("GetProduct/{id}")]
        public IActionResult Get(int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            return Ok(product);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult Post(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return Ok("Product added successfully");
        }

        [HttpPut]
        [Route("UpdateProduct/{id}")]
        public IActionResult Put(int id, Product product)
        {
            var existingProduct = context.Products.Find(id);
            if (existingProduct == null)
            {
                return NotFound("Product not found");
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Category = product.Category;

            context.SaveChanges();
            return Ok("Product updated successfully");
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            context.Products.Remove(product);
            context.SaveChanges();
            return Ok("Product deleted successfully");
        }
    }
}