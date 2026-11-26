using Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Repository;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepo repo;

        public ProductsController(IProductRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }

        [HttpGet]
        [Route("GetProductById/{id}")]  
        public IActionResult GetById(int id)
        {
            var product = repo.GetById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult Add(Product product)
        {
            repo.Add(product);
            return Ok(product);
        }

        [HttpPut]
        [Route("UpdateProduct/{id}")]
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest("ID mismatch");

            var existing = repo.GetById(id);
            if (existing == null)
                return NotFound();

            repo.Update(product);
            return Ok(product);
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            return Ok("Product Deleted");
        }
    }
}
