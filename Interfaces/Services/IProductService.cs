using Tech_Inventory_Management_System.DTOs.Product;

namespace Tech_Inventory_Management_System.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();

        Task<ProductDto?> GetProductByIdAsync(int productId);

        Task<ProductDto> AddProductAsync(CreateProductDto productDto);

        Task<bool> UpdateProductAsync(UpdateProductDto productDto);

        Task<bool> DeleteProductAsync(int productId);

        Task<IEnumerable<ProductDto>> SearchProductsAsync(string productName);
    }
}
