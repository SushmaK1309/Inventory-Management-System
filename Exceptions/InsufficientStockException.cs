using System.Net;

namespace Smart_Inventory_Management_System.Exceptions
{
    public class InsufficientStockException : ApiException
    {
        public InsufficientStockException(string productName, int requestedQuantity)
            : base(
                $"Insufficient stock available for product '{productName}'. Requested quantity: {requestedQuantity}.",
                (int)HttpStatusCode.BadRequest,
                "Insufficient Stock")
        {
        }
    }
}
