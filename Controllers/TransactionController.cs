using Microsoft.AspNetCore.Mvc;
using Tech_Inventory_Management_System.DTOs.Inventory;
using Tech_Inventory_Management_System.Interfaces.Services;

namespace Smart_Inventory_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _inventoryService;

        public TransactionController(ITransactionService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        // POST: api/InventoryTransaction/stockin
        [HttpPost("stockin")]
        public async Task<IActionResult> StockIn(StockInDto dto)
        {
            await _inventoryService.StockInAsync(dto);

            return StatusCode(201, "Stock added successfully.");
        }

        // POST: api/InventoryTransaction/stockout
        [HttpPost("stockout")]
        public async Task<IActionResult> StockOut(StockOutDto dto)
        {
            await _inventoryService.StockOutAsync(dto);

            return Ok("Stock removed successfully.");
        }

        // GET: api/InventoryTransaction
        [HttpGet]
        public async Task<IActionResult> GetAllTransactions()
        {
            var transactions = await _inventoryService.GetAllTransactionsAsync();

            return Ok(transactions);
        }

        // GET: api/InventoryTransaction/product/1
        [HttpGet("product/{productId}")]
        public async Task<IActionResult> GetTransactionsByProduct(int productId)
        {
            var transactions = await _inventoryService.GetTransactionsByProductIdAsync(productId);

            return Ok(transactions);
        }
    }
}
