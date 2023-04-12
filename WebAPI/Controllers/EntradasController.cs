using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase
    {
        private readonly IEntradasService _entradasService;
        public EntradasController(IEntradasService entradasService)
        {
            this._entradasService = entradasService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntradasDTO>>> Get()
        {
            var entradas = await _entradasService.GetAllAsync();
            if (entradas == null) 
                return NotFound("Não foram encontrados dados de Entradas!");

            return Ok(entradas);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EntradasDTO entradasDTO)
        {
            //todo: Implementar regras e automações para "DataVigencia"
            //todo: Fazer com que na sugestão do swagger não apareça o ID
            //todo: Gerar data de criação
            if (entradasDTO == null)
                return BadRequest("Dados inválidos");

            await _entradasService.Add(entradasDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EntradasDTO entradasDTO)
        {
            //todo: Atualizar somente data de modificação
            if (id != entradasDTO.Id)
                return BadRequest();

            if (entradasDTO == null)
                return BadRequest();

            await _entradasService.Update(entradasDTO);
            return Ok(entradasDTO);
        }
    }
}
