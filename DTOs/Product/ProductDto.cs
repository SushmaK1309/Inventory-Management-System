namespace Tech_Inventory_Management_System.DTOs.Product
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string CategoryName { get; set; } = string.Empty;
    }
}
