using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System  .Models;

namespace Tech_Inventory_Management_System.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public Task AddAsync(InventoryTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InventoryTransaction>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InventoryTransaction>> GetByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
