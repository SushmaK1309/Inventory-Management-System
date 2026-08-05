using Smart_Inventory_Management_System.Exceptions;
using System.ComponentModel.DataAnnotations;
using Tech_Inventory_Management_System.DTOs.Product;
using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Interfaces.Services;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<ProductResponseDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();

            return products.Select(product => new ProductResponseDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Brand = product.Brand,
                Price = product.Price,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
                IsActive = product.IsActive,
                CreatedDate = product.CreatedDate
            });
        }

        public async Task<ProductResponseDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
                throw new ProductNotFoundException(id);

            return new ProductResponseDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Brand = product.Brand,
                Price = product.Price,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
                IsActive = product.IsActive,
                CreatedDate = product.CreatedDate
            };
        }

        public async Task AddProductAsync(CreateProductDto dto)
        {
            // Validate Product Name
            if (string.IsNullOrWhiteSpace(dto.ProductName))
                throw new ValidationException("Product name is required.");

            // Check duplicate product
            var existingProduct = await _productRepository.GetByNameAsync(dto.ProductName);

            if (existingProduct != null)
                throw new DuplicateProductException(dto.ProductName);

            // Check Category exists
            var category = await _categoryRepository.GetByIdAsync(dto.CategoryId);

            if (category == null)
                throw new CategoryNotFoundException(dto.CategoryId);

            var product = new Product
            {
                ProductName = dto.ProductName,
                Brand = dto.Brand,
                Price = dto.Price,
                Quantity = dto.Quantity,
                CategoryId = dto.CategoryId,
                IsActive = true
            };

            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(int id, UpdateProductDto dto)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
                throw new ProductNotFoundException(id);

            // Check Category exists
            var category = await _categoryRepository.GetByIdAsync(dto.CategoryId);

            if (category == null)
                throw new CategoryNotFoundException(dto.CategoryId);

            product.ProductName = dto.ProductName;
            product.Brand = dto.Brand;
            product.Price = dto.Price;
            product.Quantity = dto.Quantity;
            product.CategoryId = dto.CategoryId;
            product.IsActive = dto.IsActive;

            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
    throw new ProductNotFoundException(id);

            await _productRepository.DeleteAsync(product);
        }
    }
}
