using Tech_Inventory_Management_System.DTOs.Category;

namespace Tech_Inventory_Management_System.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryResponseDto>> GetAllCategoriesAsync();

        Task<CategoryResponseDto?> GetCategoryByIdAsync(int id);

        Task AddCategoryAsync(CreateCategoryDto dto);

        Task UpdateCategoryAsync(int id, UpdateCategoryDto dto);

        Task DeleteCategoryAsync(int id);
    }
}
