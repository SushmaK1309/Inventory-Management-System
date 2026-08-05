namespace Smart_Inventory_Management_System.Exceptions
{
    public class ApiException : Exception
    {
        public int StatusCode { get; }
        public string Title { get; }

        public ApiException(
            string message,
            int statusCode,
            string title)
            : base(message)
        {
            StatusCode = statusCode;
            Title = title;
        }
    }
}
