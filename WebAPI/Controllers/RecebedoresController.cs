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
    }
}
