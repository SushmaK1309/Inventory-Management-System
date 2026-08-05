using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.DTOs.Inventory
{
    public class InventoryReportDto
    {
        public int TransactionId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public eTransactionType TransactionType { get; set; }

        public DateTime TransactionDate { get; set; }

    }
}
