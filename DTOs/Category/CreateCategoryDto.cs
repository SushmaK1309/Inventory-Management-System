using System.ComponentModel.DataAnnotations;

namespace Tech_Inventory_Management_System.DTOs.Category
{
    public class CreateCategoryDto
    {
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;
    }
}
