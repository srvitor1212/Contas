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
    }
}
