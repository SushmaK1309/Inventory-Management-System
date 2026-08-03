using Microsoft.AspNetCore.Mvc;
using Tech_Inventory_Management_System.DTOs.Product;
using Tech_Inventory_Management_System.Interfaces.Services;

namespace Smart_Inventory_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            return Ok(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
                return NotFound("Product not found.");

            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductDto dto)
        {
            await _productService.AddProductAsync(dto);

            return Ok("Product added successfully.");
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, UpdateProductDto dto)
        {
            await _productService.UpdateProductAsync(id, dto);

            return Ok("Product updated successfully.");
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(id);

            return Ok("Product deleted successfully.");
        }
    }
}
