namespace Tech_Inventory_Management_System.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public required string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
