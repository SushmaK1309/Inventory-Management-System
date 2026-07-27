using Tech_Inventory_Management_System.DTOs.Inventory;

namespace Tech_Inventory_Management_System.Interfaces.Services
{
    public interface IInventoryService
    {
        Task<bool> StockInAsync(StockInDto stockInDto);

        Task<bool> StockOutAsync(StockOutDto stockOutDto);

        Task<IEnumerable<InventoryReportDto>> GetInventoryReportAsync();
    }
}
