using System.Net;

namespace Smart_Inventory_Management_System.Exceptions
{
    public class ProductNotFoundException : ApiException
    {
        public ProductNotFoundException(int id)
            : base(
                $"Product with id {id} was not found.",
                (int)HttpStatusCode.NotFound,
                "Product Not Found")
        {
        }
    }
}
