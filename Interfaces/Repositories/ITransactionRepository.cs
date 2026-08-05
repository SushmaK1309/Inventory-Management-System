using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<InventoryTransaction>> GetAllAsync();

        Task<IEnumerable<InventoryTransaction>> GetByProductIdAsync(int productId);

        Task AddAsync(InventoryTransaction transaction);
    }
}
