using DemoApp.Application.Common.Exceptions;
using DemoApp.Domain.Responses;
using FluentValidation;
using System.Net;
using System.Text.Json;

namespace DemoApp.Web.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                ExecptionResponse errorResponse = new();

                switch (error)
                {
                    case ValidationDictionaryException e:
                        // custom application error
                        errorResponse.ConsolidatedErrorMessage = e.Message;
                        errorResponse.ErrorMessages = e.Errors.ToList();
                        
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;                   
                    default:
                        // unhandled error
                        errorResponse.ConsolidatedErrorMessage = "Unhandled Error";
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                

                var result = JsonSerializer.Serialize(errorResponse);
                await response.WriteAsync(result);
            }
        }
    }
}
