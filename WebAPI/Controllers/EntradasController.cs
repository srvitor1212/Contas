using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("teste/[controller]")]
    public class EntradasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll() 
        {
            return new string[] { "valor1", "valor2", "valor3" };
        }
    }
}
