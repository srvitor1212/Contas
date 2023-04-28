using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DividasController : ControllerBase
    {
        private readonly IDividasService _dividasService;
        private readonly IPagamentosServices _pagamentosService;
        private readonly IRecebedoresService _recebedoresService;
        public DividasController(
            IDividasService dividasService,
            IPagamentosServices pagamentosService,
            IRecebedoresService recebedoresService)
        {
            this._dividasService = dividasService;
            this._pagamentosService = pagamentosService;
            this._recebedoresService = recebedoresService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DividasDTO>>> Get()
        {
            var dividas = await _dividasService.GetAllAsync();
            return Ok(dividas);
        }

        [HttpGet("{id}", Name = "GetDivida")]
        public async Task<ActionResult<DividasDTO>> Get(int id)
        {
            var dividaDTO = await _dividasService.GetById(id);
            if (dividaDTO == null)
                return NotFound();

            return Ok(dividaDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DividasViewModel dividasViewModel)
        {
            ModelNormalized(dividasViewModel);
            dividasViewModel.FoiPago = false;

            if (dividasViewModel.DataInicio > dividasViewModel.DataFim)
                return BadRequest("Data inicio maior que data fim");

            var pagamento = await _pagamentosService.GetById(dividasViewModel.PagamentosId);
            if (pagamento == null)
            {
                dividasViewModel.PagamentosId = 1;
                pagamento = await _pagamentosService.GetById(dividasViewModel.PagamentosId);
            }

            var recebedor = await _recebedoresService.GetById(dividasViewModel.RecebedoresId);
            if (recebedor == null)
            {
                dividasViewModel.RecebedoresId = 1;
                recebedor = await _recebedoresService.GetById(dividasViewModel.RecebedoresId);
            }

            DividasDTO dividaDTO = new DividasDTO(
                dividasViewModel.Nome,
                dividasViewModel.Valor,
                dividasViewModel.FoiPago,
                dividasViewModel.DataInicio,
                dividasViewModel.DataFim,
                dividasViewModel.DiaVencimento,
                dividasViewModel.PagamentosId,
                dividasViewModel.RecebedoresId);

            var createdDTO = await _dividasService.Add(dividaDTO);
            return Created("", createdDTO);
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] DividasViewModel dividasViewModel)
        {
            var dividaEntity = await _dividasService.GetById(id);
            if (dividaEntity == null)
                return NotFound("Registro divida não encontrado");

            var pagamento = await _pagamentosService.GetById(dividasViewModel.PagamentosId);
            if (pagamento == null)
                return BadRequest("Pagamento informado não existe");

            var recebedor = await _recebedoresService.GetById(dividasViewModel.RecebedoresId);
            if (recebedor == null)
                return BadRequest("Recebedor informado não existe");

            ModelNormalized(dividasViewModel);

            DividasDTO dividasDTO = new DividasDTO(
                id,
                dividasViewModel.Nome,
                dividasViewModel.Valor,
                dividasViewModel.FoiPago,
                dividasViewModel.DataInicio,
                dividasViewModel.DataFim,
                dividasViewModel.DiaVencimento,
                dividasViewModel.PagamentosId,
                dividasViewModel.RecebedoresId);

            await _dividasService.Update(dividasDTO);
            return Ok(dividasViewModel);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
                return NotFound();

            var dividaDTO = await _dividasService.GetById(id);
            if (dividaDTO == null)
                return NotFound();

            await _dividasService.Delete(id);
            return Ok();
        }

        private void ModelNormalized(DividasViewModel model)
        {
            model.DataInicio = new DateTime(
                model.DataInicio.Year,
                model.DataInicio.Month,
                model.DataInicio.Day,
                00, 00, 00, 000);
            model.DataFim = new DateTime(
                model.DataFim.Year,
                model.DataFim.Month,
                model.DataFim.Day,
                23, 59, 59, 999);

            if (model.DiaVencimento < 1 || model.DiaVencimento > 28)
                model.DiaVencimento = 10;
        }
    }
}
