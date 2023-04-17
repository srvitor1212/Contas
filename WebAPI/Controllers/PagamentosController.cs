using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly IPagamentosServices _pagamentosServices;
        public PagamentosController(IPagamentosServices pagamentosServices)
        {
            this._pagamentosServices = pagamentosServices;
        }
    }
}
