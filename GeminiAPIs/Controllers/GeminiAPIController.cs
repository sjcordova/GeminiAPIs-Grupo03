using GeminiAPIs.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeminiAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeminiAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerRespuestaGemini(string prompt)
        {
            GeminiApisRespository repo = new GeminiApisRespository();
            var respuesta = repo.DevuelveRespuestaAI(prompt);
            return Ok(respuesta);
        }
    }
}
