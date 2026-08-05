using System.Net;

namespace Smart_Inventory_Management_System.Exceptions
{
    public class DuplicateProductException : ApiException
    {
        public DuplicateProductException(string productName)
            : base(
                $"Product '{productName}' already exists.",
                (int)HttpStatusCode.Conflict,
                "Duplicate Product")
        {
        }
    }
}
