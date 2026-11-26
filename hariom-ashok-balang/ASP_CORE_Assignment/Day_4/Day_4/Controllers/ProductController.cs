using Day_4_Dotnet_Core_Backend_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day_4_Dotnet_Core_Backend_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private MyDbContext context;

        public ProductController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("getProducts")]
        public IActionResult Get()
        {
            var data = context.Products
                .Include(p => p.Category)
                .ToList();

            return Ok(data);
        }
    }
}
