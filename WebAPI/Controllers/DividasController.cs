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
        public DividasController(IDividasService dividasService)
        {
            this._dividasService = dividasService;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DividasViewModel dividasViewModel)
        {
            ModelNormalized(dividasViewModel);

            if (dividasViewModel.DataInicio > dividasViewModel.DataFim)
                return BadRequest("Data inicio maior que data fim");

            //todo: validar se pagamento e recebedor existem
            throw new NotImplementedException();
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
