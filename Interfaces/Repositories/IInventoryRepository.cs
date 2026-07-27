using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Interfaces.Repositories
{
    public interface IInventoryRepository
    {
        Task AddTransactionAsync(InventoryTransaction transaction);

        Task<IEnumerable<InventoryTransaction>> GetAllTransactionsAsync();
    }
}
