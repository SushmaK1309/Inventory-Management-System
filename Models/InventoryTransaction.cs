using System.ComponentModel.DataAnnotations;

namespace Tech_Inventory_Management_System.Models
{
    public class InventoryTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity should be at least 1.")]
        public int Quantity { get; set; }

        [Required]
        public eTransactionType TransactionType { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    }
    public enum eTransactionType
    {
        StockIn,
        StockOut
    }
}
