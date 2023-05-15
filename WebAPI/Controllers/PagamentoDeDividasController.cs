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

        [HttpGet("{id}", Name = "GetPagamentoDeDivida")]
        public async Task<ActionResult<PagamentoDeDividasDTO>> Get(int id)
        {
            var pagamentoDTO = await _pagamentoDeDividasService.GetByIdAsync(id);
            if (pagamentoDTO == null)
                return NotFound();

            return Ok(pagamentoDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PagamentoDeDividasDTO pagamentoDeDividasDTO)
        {
            //todo: criar uma view model para não mostra ID, e na DTO mostrar o ID
            var divida = await _dividasService.GetById(pagamentoDeDividasDTO.DividasId);
            if (divida == null)
                return NotFound();

            var created = await _pagamentoDeDividasService.CreateAsync(pagamentoDeDividasDTO);
            return Created("", created);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
                return NotFound();

            var pagamentoDTO = await _pagamentoDeDividasService.GetByIdAsync(id);
            if (pagamentoDTO == null)
                return NotFound();

            await _pagamentoDeDividasService.DeleteAsync(id);
            return Ok();
        }
    }
}
