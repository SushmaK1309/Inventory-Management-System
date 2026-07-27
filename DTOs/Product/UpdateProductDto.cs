using System.ComponentModel.DataAnnotations;

namespace Tech_Inventory_Management_System.DTOs.Product
{
    public class UpdateProductDto
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; } = string.Empty;

        [Range(1, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
