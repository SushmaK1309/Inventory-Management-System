using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Models;

namespace Smart_Inventory_Management_System.Repositories
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
        // In-memory storage
        private static readonly List<Category> _categories = new()
        {
            new Category
            {
                CategoryId = 1,
                CategoryName = "Laptops",
                IsActive = true
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Monitors",
                IsActive = true
            }
        };

        public Task<IEnumerable<Category>> GetAllAsync()
        {
            return Task.FromResult(_categories.AsEnumerable());
        }

        public Task<Category?> GetByIdAsync(int id)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);

            return Task.FromResult(category);
        }

        public Task<Category?> GetByNameAsync(string categoryName)
        {
            var category = _categories.FirstOrDefault(c =>
                c.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            return Task.FromResult(category);
        }

        public Task AddAsync(Category category)
        {
            category.CategoryId = _categories.Any()
                ? _categories.Max(c => c.CategoryId) + 1
                : 1;

            _categories.Add(category);

            return Task.CompletedTask;
        }

        public Task UpdateAsync(Category category)
        {
            var existingCategory = _categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (existingCategory != null)
            {
                existingCategory.CategoryName = category.CategoryName;
                existingCategory.IsActive = category.IsActive;
            }

            return Task.CompletedTask;
        }

        public Task DeleteAsync(Category category)
        {
            _categories.Remove(category);

            return Task.CompletedTask;
        }
    }
}
