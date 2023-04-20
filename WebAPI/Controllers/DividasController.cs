﻿using Application.DTOs;
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

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DividasViewModel dividasViewModel)
        {
            ModelNormalized(dividasViewModel);

            if (dividasViewModel.DataInicio > dividasViewModel.DataFim)
                return BadRequest("Data inicio maior que data fim");

            var pagamento = await _pagamentosService.GetById(dividasViewModel.PagamentosId);
            if (pagamento == null)
                return BadRequest("Pagamento não existe"); //todo: Colocar como padrão dinheiro

            var recebedor = await _recebedoresService.GetById(dividasViewModel.RecebedoresId);
            if (recebedor == null)
                return BadRequest("Recebedor não existe"); //todo: Colocar um valor padrão em caso de zero

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
            return Ok(createdDTO);
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
