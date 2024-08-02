using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartShoppingList.Server.Models;
using SmartShoppingList.Server.Entities;
namespace SmartShoppingList.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        public ProductsController() { 

        }
        [HttpGet("search")]
        public async  Task<IActionResult> SearchProduct([FromQuery] string productName)
        {

        }
        public async Task<IActionResult> AddProductManually([FromBody] ProductDto productDto)
        {
            var Product = new Product
            {
                Name = productDto.Name,
                Category = productDto.CategoryName
            };
        }
    }
}
