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
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            //context.Result = new ObjectResult("ERRO INTERNO DO SERVIDOR! :(");
            context.Result = new ObjectResult("" +
                "{" +
                "\"status\" : \"Error\", " +
                "\"Message\" : \"Erro interno do servidor\"" +
                "}");
            //context.Result = new ObjectResult(new RespostaErroJson(string.Format(Resource.ThrowUnknownError_Error_Throw, nameof(ThrowUnknownError), context.Exception.Message)));
        }
    }
}
