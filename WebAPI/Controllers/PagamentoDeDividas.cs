using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoDeDividas : ControllerBase
    {
        private readonly IPagamentoDeDividasService _pagamentoDeDividasService;
        public PagamentoDeDividas(
            IPagamentoDeDividasService pagamentoDeDividasService)
        {
            this._pagamentoDeDividasService = pagamentoDeDividasService;
        }
    }
}
