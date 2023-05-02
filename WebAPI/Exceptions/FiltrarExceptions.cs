using Domain.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace WebAPI.Exceptions
{
    public class FiltrarExceptions : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            ThrowUnknownError(context);

            /*
            if (context.Exception is DomainValidation)
            {
                //todo: trata exceções
            } else
            {
                ThrowUnknownError(context);
            }
            */
        }

        private static void ThrowUnknownError(ExceptionContext context)
        {
            var jsonRetorno = new
            {
                status = "error",
                source = context.Exception.Source,
                exception = context.Exception.Message
            };

            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Result = new ObjectResult(jsonRetorno);
        }
    }
}
