using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Repositories
{
    public class InMemoryTransactionRepository : ITransactionRepository
    {
        private readonly List<InventoryTransaction> _transactions;


        public InMemoryTransactionRepository()
        {
            _transactions = new List<InventoryTransaction>();
        }


        public Task<IEnumerable<InventoryTransaction>> GetAllAsync()
        {
            return Task.FromResult(
                _transactions.AsEnumerable()
            );
        }


        public Task<IEnumerable<InventoryTransaction>> GetByProductIdAsync(int productId)
        {
            var transactions = _transactions
                .Where(t => t.ProductId == productId)
                .AsEnumerable();

            return Task.FromResult(transactions);
        }


        public Task AddAsync(InventoryTransaction transaction)
        {
            transaction.TransactionId = _transactions.Count + 1;
            transaction.TransactionDate = DateTime.Now;

            _transactions.Add(transaction);

            return Task.CompletedTask;
        }
    }
}