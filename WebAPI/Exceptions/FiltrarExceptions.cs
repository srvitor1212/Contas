using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPI.Exceptions
{
    public class FiltrarExceptions : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
