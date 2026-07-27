using Tech_Inventory_Management_System.DTOs.Category;
using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Interfaces.Services;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CategoryResponseDto>> GetAllCategoriesAsync()
        {
            var categories = await _repository.GetAllAsync();

            return categories.Select(c => new CategoryResponseDto
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                IsActive = c.IsActive
            });
        }

        public async Task<CategoryResponseDto?> GetCategoryByIdAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category == null)
                return null;

            return new CategoryResponseDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                IsActive = category.IsActive
            };
        }

        public async Task AddCategoryAsync(CreateCategoryDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.CategoryName))
                throw new Exception("Category Name is required.");

            var existing = await _repository.GetByNameAsync(dto.CategoryName);

            if (existing != null)
                throw new Exception("Category already exists.");

            var category = new Category
            {
                CategoryName = dto.CategoryName
            };

            await _repository.AddAsync(category);
        }

        public async Task UpdateCategoryAsync(int id, UpdateCategoryDto dto)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category == null)
                throw new Exception("Category not found.");

            category.CategoryName = dto.CategoryName;
            category.IsActive = dto.IsActive;

            await _repository.UpdateAsync(category);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _repository.GetByIdAsync(id);

            if (category == null)
                throw new Exception("Category not found.");

            await _repository.DeleteAsync(category);
        }
    }
}
