using Microsoft.AspNetCore.Mvc;
using ProyectoBackendHerbert.Context;
using ProyectoBackendHerbert.Models;

namespace ProyectoBackendHerbert.Controllers
{

    [ApiController]
    [Route("[controller]")]


    public class RelacionController : Controller
    {
        public readonly AplicacionContext aplicacionContext;
        public RelacionController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarR")]
        public async Task<IActionResult> MostrarR()
        {
            List<Relacion> relacions = aplicacionContext.Relacion.OrderByDescending(relacions => relacions.nombre).ToList();
            return StatusCode(StatusCodes.Status200OK, relacions);

        }
        [HttpPost]
        [Route("CrearR")]
        public async Task<IActionResult> CrearR([FromBody] Relacion relacion)
        {
            aplicacionContext.Relacion.Add(relacion);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Creado Correctamente");

        }
        [HttpPut]
        [Route("EditarAutos")]
        public async Task<IActionResult> EditarR([FromBody] Relacion relacion)
        {
            aplicacionContext.Relacion.Update(relacion);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Editado Correctamente");

        }
        [HttpDelete]
        [Route("EliminarAutos/")]
        public async Task<IActionResult> EliminarR(int Nombre)
        {
            Relacion relacion = aplicacionContext.Relacion.Find(Nombre);
            aplicacionContext.Relacion.Remove(relacion);
            aplicacionContext.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, "Eliminado Correctamente");
        }


    }
}
