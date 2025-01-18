using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistroTecnicos.Contoller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicoController : ControllerBase
    {

        [HttpGet("ConexionServidor")]

        public async Task<ActionResult<string>> Getejemplo()
        {

            return "Conectar con el servidor";

        }
    }
}
