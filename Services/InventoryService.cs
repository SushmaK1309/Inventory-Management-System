using Tech_Inventory_Management_System.DTOs.Inventory;
using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Interfaces.Services;

namespace Tech_Inventory_Management_System.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<bool> StockInAsync(StockInDto stockInDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StockOutAsync(StockOutDto stockOutDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<InventoryReportDto>> GetInventoryReportAsync()
        {
            throw new NotImplementedException();
        }
    }
}
