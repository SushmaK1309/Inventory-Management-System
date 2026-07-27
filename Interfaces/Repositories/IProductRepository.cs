using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product?> GetByIdAsync(int productId);

        Task<Product> AddAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);

        Task<IEnumerable<Product>> SearchAsync(string productName);
    }
}
