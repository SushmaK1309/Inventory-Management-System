using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product?> GetByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> SearchAsync(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
