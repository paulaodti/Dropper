using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dropper.API.Models
{
    public class ResponseGenerator
    {
        public static Object GenerateSuccessResponse(int statusCode, string message, Object data)
        {
            return new
            {
                StatusCode = statusCode,
                Message = message,
                Data = data
            };
        }

        public static Object GenerateErrorResponse(int statusCode, string message, Exception exception)
        {
            String details;
            if (exception.InnerException != null && exception.InnerException.InnerException != null)
            {
                details = exception.InnerException.InnerException.Message;
            }
            else if (exception.InnerException != null)
            {
                details = exception.InnerException.Message;
            }
            else
            {
                details = exception.Message;
            }

            return new
            {
                StatusCode = statusCode,
                errorMessage = message,
                errorDetails = details,
            };
        }
    }
}
