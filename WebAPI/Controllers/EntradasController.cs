using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase
    {
        //todo: implmentar respostas HTTP adequadas
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

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<EntradasDTO>> Get(int id)
        {
            var entrada = await _entradasService.GetById(id);
            return Ok(entrada);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EntradasViewModel entradasViewModel)
        {
            DateTime dataVigenciaTratada = DataVigencia_Normalized(
                entradasViewModel.DataVigencia.Year,
                entradasViewModel.DataVigencia.Month,
                entradasViewModel.DataVigencia.Day
                );
            entradasViewModel.DataVigencia = dataVigenciaTratada;

            EntradasDTO entradasDTO     = new EntradasDTO();
            entradasDTO.Nome            = entradasViewModel.Nome;
            entradasDTO.Valor           = entradasViewModel.Valor;
            entradasDTO.DataVigencia    = entradasViewModel.DataVigencia;

            if (entradasDTO == null)
                return BadRequest("Dados inválidos");

            await _entradasService.Add(entradasDTO);
            return Ok(); //todo: retornar no método getbyid
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EntradasDTO entradasDTO)
        {
            DateTime dataVigenciaTratada = DataVigencia_Normalized(
                entradasDTO.DataVigencia.Year,
                entradasDTO.DataVigencia.Month,
                entradasDTO.DataVigencia.Day
                );
            entradasDTO.DataVigencia = dataVigenciaTratada;

            if (id != entradasDTO.Id)
                return BadRequest();

            if (entradasDTO == null)
                return BadRequest();

            await _entradasService.Update(entradasDTO);
            return Ok(entradasDTO);
        }

        private DateTime DataVigencia_Normalized(int year, int month, int day)
        {
            return new DateTime(year, month, day, 23, 59, 59, 999);
        }
    }
}
