using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        // In-memory storage
        private static readonly List<Product> _products = new()
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Dell Latitude 5440",
                Brand = "Dell",
                Price = 65000,
                Quantity = 15,
                CategoryId = 1,
                IsActive = true,
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                ProductId = 2,
                ProductName = "HP ProBook 450",
                Brand = "HP",
                Price = 62000,
                Quantity = 10,
                CategoryId = 1,
                IsActive = true,
                CreatedDate = DateTime.UtcNow
            }
        };

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return Task.FromResult(_products.AsEnumerable());
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);

            return Task.FromResult(product);
        }

        public Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId)
        {
            var products = _products.Where(p => p.CategoryId == categoryId);

            return Task.FromResult(products.AsEnumerable());
        }

        public Task<Product?> GetByNameAsync(string productName)
        {
            var product = _products.FirstOrDefault(p =>
                p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            return Task.FromResult(product);
        }

        public Task AddAsync(Product product)
        {
            product.ProductId = _products.Any()
                ? _products.Max(p => p.ProductId) + 1
                : 1;

            product.CreatedDate = DateTime.UtcNow;

            _products.Add(product);

            return Task.CompletedTask;
        }

        public Task UpdateAsync(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.Brand = product.Brand;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.IsActive = product.IsActive;
            }

            return Task.CompletedTask;
        }

        public Task DeleteAsync(Product product)
        {
            _products.Remove(product);

            return Task.CompletedTask;
        }
    }
}