using System.ComponentModel.DataAnnotations;

namespace Tech_Inventory_Management_System.DTOs.Product
{
    public class CreateProductDto
    {
        public string ProductName { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }
    }
}
