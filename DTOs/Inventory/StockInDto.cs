using System.ComponentModel.DataAnnotations;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.DTOs.Inventory
{
    public class StockInDto
    {
        [Required]
        public int ProductId { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
