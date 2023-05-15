using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoDeDividasController : ControllerBase
    {
        private readonly IPagamentoDeDividasService _pagamentoDeDividasService;
        private readonly IDividasService _dividasService;
        public PagamentoDeDividasController(
            IPagamentoDeDividasService pagamentoDeDividasService,
            IDividasService dividasService)
        {
            this._pagamentoDeDividasService = pagamentoDeDividasService;
            this._dividasService = dividasService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PagamentoDeDividasDTO>>> Get()
        {
            return Ok(await _pagamentoDeDividasService.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PagamentoDeDividasDTO pagamentoDeDividasDTO)
        {
            var divida = await _dividasService.GetById(pagamentoDeDividasDTO.DividasId);
            if (divida == null)
                return NotFound();

            var created = await _pagamentoDeDividasService.CreateAsync(pagamentoDeDividasDTO);
            return Created("", created);
        }
    }
}
