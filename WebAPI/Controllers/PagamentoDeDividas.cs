using Application.DTOs;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PagamentoDeDividasDTO>>> Get(int idDivida)
        {
            if (idDivida <= 0)
                return NotFound();

            await _pagamentoDeDividasService.GetAllAsync(idDivida);

            return BadRequest();
        }
    }
}
