using Tech_Inventory_Management_System.DTOs.Product;
using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Interfaces.Services;

namespace Tech_Inventory_Management_System.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto?> GetProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> AddProductAsync(CreateProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateProductAsync(UpdateProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> SearchProductsAsync(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
