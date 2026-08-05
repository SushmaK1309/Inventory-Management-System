using Tech_Inventory_Management_System.DTOs.Inventory;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Interfaces.Services
{
    public interface ITransactionService
    {
        Task StockInAsync(StockInDto dto);

        Task StockOutAsync(StockOutDto dto);

        Task<IEnumerable<InventoryTransaction>> GetAllTransactionsAsync();

        Task<IEnumerable<InventoryTransaction>> GetTransactionsByProductIdAsync(int productId);
    }
}
