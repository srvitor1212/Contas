using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PagamentosDTO>>> Get()
        {
            var pagamentos = await _pagamentosServices.GetAllAsync();
            return Ok(pagamentos);
        }

        [HttpGet("{id}", Name = "GetPagamentos")]
        public async Task<ActionResult<PagamentosDTO>> Get(int id)
        {
            var pagamentosDTO = await _pagamentosServices.GetById(id);
            if (pagamentosDTO == null)
                return NotFound();

            return Ok(pagamentosDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PagamentosViewModel pagamentosViewModel)
        {
            PagamentosDTO pagamentosDTO = new PagamentosDTO();            
            pagamentosDTO.Nome = pagamentosViewModel.Nome;

            var createdDTO = await _pagamentosServices.Add(pagamentosDTO);
            return Created("", createdDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PagamentosDTO pagamentosDTO)
        {
            if (id == 1 || pagamentosDTO.Id == 1)
                return BadRequest("Pagamento em Dinheiro não pode ser alterado");

            if (id != pagamentosDTO.Id)
                return BadRequest("Id não confere");

            var pagamentoEntity = await _pagamentosServices.GetById(id);
            if (pagamentoEntity == null)
                return NotFound("Registro não encontrado");

            await _pagamentosServices.Update(pagamentosDTO);
            return Ok(pagamentosDTO);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 1)
                return BadRequest("Pagamento em Dinheiro não pode ser alterado");

            if (id == 0)
                return NotFound();

            var pagamentoEntity = await _pagamentosServices.GetById(id);
            if (pagamentoEntity == null)
                return NotFound();

            await _pagamentosServices.Delete(id);
            return Ok();
        }
    }
}
