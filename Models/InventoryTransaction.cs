namespace Tech_Inventory_Management_System.Models
{
    public class InventoryTransaction
    {
        public int TransactionId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        // StockIn / StockOut
        public eTransactionType TransactionType { get; set; } 

        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    }
    public enum eTransactionType
    {
        StockIn,
        StockOut
    }
}
