using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System  .Models;

namespace Tech_Inventory_Management_System.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        public async Task AddTransactionAsync(InventoryTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<InventoryTransaction>> GetAllTransactionsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
