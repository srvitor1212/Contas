using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        }

    }
}
