using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product?> GetByIdAsync(int id);

        Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId);

        Task<Product?> GetByNameAsync(string productName);

        Task AddAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);
    }
}
