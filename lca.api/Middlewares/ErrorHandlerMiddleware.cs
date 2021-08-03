using LCA.Service.BusinessExceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace LCA.API.Middlewares
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

                string jsonResult;
                switch (error)
                {
                    case LcaException e:
                        response.StatusCode = (int)e.StatusCode;
                        jsonResult = JsonSerializer.Serialize(e.ToSerializableObject());
                        break;
                    default:
                        // unhandled error
                        jsonResult = JsonSerializer.Serialize(new { MessageCode = "LCA_ERROR_UNKNOWN", error?.Message });
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                await response.WriteAsync(jsonResult);
            }
        }
    }
}
