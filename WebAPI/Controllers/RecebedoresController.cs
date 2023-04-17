using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecebedoresController : ControllerBase
    {
        private readonly IRecebedoresService _recebedoresService;
        public RecebedoresController(IRecebedoresService recebedoresService)
        {
            this._recebedoresService = recebedoresService;
        }
        //todo: terminar o CRUD

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecebedoresDTO>>> Get()
        {
            var recebedores = await _recebedoresService.GetAllAsync();
            return Ok(recebedores);
        }

        [HttpGet("{id}", Name = "GetRecebedor")]
        public async Task<ActionResult<RecebedoresDTO>> Get(int id)
        {
            var recebedoresDTO = await _recebedoresService.GetById(id);
            if (recebedoresDTO == null)
                return NotFound();

            return Ok(recebedoresDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RecebedoresViewModel recebedoresViewModel)
        {
            RecebedoresDTO recebedoresDTO   = new RecebedoresDTO();
            recebedoresDTO.Nome             = recebedoresViewModel.Nome;

            var createdDTO = await _recebedoresService.Add(recebedoresDTO);
            return Created("", createdDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put (int id, [FromBody] RecebedoresDTO recebedoresDTO)
        {
            if (id != recebedoresDTO.Id)
                return BadRequest("Id não confere");

            var recebedorEntity = await _recebedoresService.GetById(id);
            if (recebedorEntity == null)
                return BadRequest("Registro não encontrado");

            await _recebedoresService.Update(recebedoresDTO);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
                return NotFound();

            var recebedorDTO = await _recebedoresService.GetById(id);
            if (recebedorDTO == null)
                return NotFound();

            await _recebedoresService.Delete(id);
            return Ok();
        }
    }
}
