using Microsoft.AspNetCore.Mvc;
using ProyectoBackendHerbert.Context;
using ProyectoBackendHerbert.Models;

namespace ProyectoBackendHerbert.Controllers
{

    [ApiController]
    [Route("[controller]")]


    public class HangarController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public HangarController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarHangares")]
        public async Task<IActionResult> MostrarHangares()
        {
            List<Hangar> hangares = aplicacionContext.Hangar.OrderByDescending(hangares => hangares.idHangar).ToList();
            return StatusCode(StatusCodes.Status200OK, hangares);

        }
        [HttpPost]
        [Route("CrearHangares")]
        public async Task<IActionResult> CrearHangares([FromBody] Hangar hangar)
        {
            aplicacionContext.Hangar.Add(hangar);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarHangares")]
        public async Task<IActionResult> EditarHangares([FromBody] Hangar hangar)
        {
            aplicacionContext.Hangar.Update(hangar);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarHangares/")]
        public async Task<IActionResult> EliminarHangares(int id)
        {
            Hangar hangar = aplicacionContext.Hangar.Find(id);
            aplicacionContext.Hangar.Remove(hangar);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }


    }
}
