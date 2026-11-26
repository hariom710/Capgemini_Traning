using Day_1.Data;
using Day_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(ProductRepository.Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = ProductRepository.Products.Max(p => p.Id) + 1;
            ProductRepository.Products.Add(product);

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updatedProduct)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound("Product not found");

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound("Product not found");

            ProductRepository.Products.Remove(product);

            return Ok("Product deleted");
        }
    }
}
