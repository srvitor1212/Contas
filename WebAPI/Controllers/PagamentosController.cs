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
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "GetPagamentos")]
        public async Task<ActionResult<PagamentosDTO>> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PagamentosViewModel pagamentosViewModel)
        {
            PagamentosDTO pagamentosDTO = new PagamentosDTO();            
            pagamentosDTO.Nome = pagamentosViewModel.Nome;

            var createdDTO = _pagamentosServices.Add(pagamentosDTO);
            return Created("", createdDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PagamentosDTO pagamentosDTO)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
