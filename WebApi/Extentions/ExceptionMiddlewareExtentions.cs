using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;
using WebApi.Errors;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebApi.Extentions
{
    public class ExceptionMiddlewareExtentions : IMiddleware
    {
        private readonly ILogger<ExceptionMiddlewareExtentions> _logger;
        private readonly IHostEnvironment _env;
        public ExceptionMiddlewareExtentions(ILogger<ExceptionMiddlewareExtentions> logger, IHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        } 

                    
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch(Exception ex)
            {
                ApiError response;
                HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
                string message;
                var exceptionType = ex.GetType();

                if(exceptionType == typeof(UnauthorizedAccessException))
                {
                    statusCode = HttpStatusCode.Forbidden;
                    message = "You are not autohorized"; 
                }
                else
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    message = "An internal server error has occurred";
                }

                if(_env.IsDevelopment())
                {
                    response = new ApiError((int)statusCode, ex.Message, ex.StackTrace.ToString());
                }
                else
                {
                    response = new ApiError((int)statusCode, message);
                }
                _logger.LogError(ex, ex.Message);

                context.Response.StatusCode = (int)statusCode;

                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(response.ToString()); 
            }

            // {
            //     _logger.LogError(ex, ex.Message);
            //     context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            //     ProblemDetails problem = new()
            //     {
            //         Status = (int)HttpStatusCode.InternalServerError,
            //         Type = "Server error",
            //         Title = "Server error",
            //         Detail = "An internal server error has occurred"
            //     };

            //     string json = JsonSerializer.Serialize(problem);

            //     context.Response.ContentType = "application/json";

            //     await context.Response.WriteAsync(json); 
            // }
        }
    }
}