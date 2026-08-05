using Microsoft.AspNetCore.Mvc;
using Smart_Inventory_Management_System.Exceptions;
using System.Net;
using System.Text.Json;

namespace Tech_Inventory_Management_System.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log based on exception type
                if (ex is ApiException apiEx && apiEx.StatusCode < 500)
                {
                    _logger.LogWarning(ex, ex.Message); //used for business exceptions.
                }
                else
                {
                    _logger.LogError(ex, ex.Message); //used for unexpected exceptions.
                }

                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            int statusCode = (int)HttpStatusCode.InternalServerError;
            string title = "An unexpected error occurred.";

            if (exception is ApiException apiException)
            {
                statusCode = apiException.StatusCode;
                title = apiException.Title;
            }

            var problemDetails = new ProblemDetails
            {
                Type = $"https://httpstatuses.com/{statusCode}",
                Title = title,
                Status = statusCode,
                Detail = statusCode == StatusCodes.Status500InternalServerError
                    ? "An unexpected error occurred. Please try again later." : exception.Message,
                Instance = context.Request.Path
            };

            //problemDetails.Extensions["traceId"] = context.TraceIdentifier;

            context.Response.ContentType = "application/problem+json";
            context.Response.StatusCode = statusCode;

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(problemDetails, options);

            await context.Response.WriteAsync(json);
        }
    }
}