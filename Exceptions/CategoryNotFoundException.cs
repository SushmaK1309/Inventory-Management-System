using System.Net;

namespace Smart_Inventory_Management_System.Exceptions
{
    public class CategoryNotFoundException : ApiException
    {
        public CategoryNotFoundException(int id)
            : base(
                $"Category with id {id} was not found.",
                (int)HttpStatusCode.NotFound,
                "Category Not Found")
        {
        }
    }
}
