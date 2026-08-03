using Tech_Inventory_Management_System.DTOs.Product;

namespace Tech_Inventory_Management_System.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponseDto>> GetAllProductsAsync();

        Task<ProductResponseDto?> GetProductByIdAsync(int id);

        Task AddProductAsync(CreateProductDto dto);

        Task UpdateProductAsync(int id, UpdateProductDto dto);

        Task DeleteProductAsync(int id);
    }
}
