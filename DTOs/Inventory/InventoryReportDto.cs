namespace Tech_Inventory_Management_System.DTOs.Inventory
{
    public class InventoryReportDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string CategoryName { get; set; } = string.Empty;

        public int AvailableQuantity { get; set; }
    }
}
