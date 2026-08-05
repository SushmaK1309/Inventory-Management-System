using Smart_Inventory_Management_System.Exceptions;
using Tech_Inventory_Management_System.DTOs.Inventory;
using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Interfaces.Services;
using Tech_Inventory_Management_System.Models;

namespace Tech_Inventory_Management_System.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IProductRepository _productRepository;

        public TransactionService(
            ITransactionRepository transactionRepository,
            IProductRepository productRepository)
        {
            _transactionRepository = transactionRepository;
            _productRepository = productRepository;
        }

        public async Task StockInAsync(StockInDto dto)
        {
            var product = await _productRepository.GetByIdAsync(dto.ProductId);

            if (product == null)
                throw new ProductNotFoundException(dto.ProductId);

            product.Quantity += dto.Quantity;

            await _productRepository.UpdateAsync(product);

            var transaction = new InventoryTransaction
            {
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                TransactionType = eTransactionType.StockIn
            };

            await _transactionRepository.AddAsync(transaction);
        }

        public async Task StockOutAsync(StockOutDto dto)
        {
            var product = await _productRepository.GetByIdAsync(dto.ProductId);

            if (product == null)
                throw new ProductNotFoundException(dto.ProductId);

            if (product.Quantity < dto.Quantity)
                throw new InsufficientStockException(product.ProductName, dto.Quantity);

            product.Quantity -= dto.Quantity;

            await _productRepository.UpdateAsync(product);

            var transaction = new InventoryTransaction
            {
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                TransactionType = eTransactionType.StockOut
            };

            await _transactionRepository.AddAsync(transaction);
        }

        public async Task<IEnumerable<InventoryTransaction>> GetAllTransactionsAsync()
        {
            return await _transactionRepository.GetAllAsync();
        }

        public async Task<IEnumerable<InventoryTransaction>> GetTransactionsByProductIdAsync(int productId)
        {
            return await _transactionRepository.GetByProductIdAsync(productId);
        }
    }
}
