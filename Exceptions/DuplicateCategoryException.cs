using System.Net;

namespace Smart_Inventory_Management_System.Exceptions
{
    public class DuplicateCategoryException : ApiException
    {
        public DuplicateCategoryException(string categoryName)
            : base(
                $"Category '{categoryName}' already exists.",
                (int)HttpStatusCode.Conflict,
                "Duplicate Category")
        {
        }
    }
}
