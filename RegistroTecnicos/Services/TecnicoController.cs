using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroTecnicos.Models;

namespace RegistroTecnicos.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicoController : ControllerBase
    {
        private readonly TecnicoContext _context;

        public TecnicoController(TecnicoContext context)
        {
            _context = context;
        }

        [HttpGet("ConexionTecnicos")]
        public async Task<ActionResult<string>> GetConexionTecnicos()
        {
            try
            {
                var respuesta = await _context.Tecnicos.ToListAsync();
                return "Conectado con la base de datos de Técnico";
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error de conexión con Técnico");
            }
        }

        [HttpPost("NuevoTecnico")]
        public async Task<ActionResult<string>> CreateTecnico([FromBody] Tecnicos objeto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Datos inválidos.");
            }

            try
            {
                _context.Tecnicos.Add(objeto);
                await _context.SaveChangesAsync();
                return "Guardado con éxito";
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al guardar el técnico");
            }
        }
    }
}