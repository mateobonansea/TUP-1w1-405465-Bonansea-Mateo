using BackEnd.Entidades;
using BackEnd.Fachada.Implementacion;
using BackEnd.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarpinteriaApi.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : ControllerBase
    {
        private IAplicacion app;
        public PresupuestoController()
        {
            app= new Aplicacion();
        }
        [HttpGet("/productos")]
        public IActionResult GetProductos()
        {
            List<Producto> products;
            try
            {
                products = app.GetProductos();
                return Ok(products);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Error Interno!! Intente luego");
            }
        }

        [HttpPost("/presupuesto")]
        public IActionResult PostPresupuesto(Presupuesto p)
        {
            try
            {
                if (p == null)
                {
                    return BadRequest("Datos del presupuesto incorrecto");
                }
                return Ok(app.SavePresupuesto(p));
            }
            catch (Exception e)
            {

                return StatusCode(500, "Error interno, intente luego");
            }
        }
    }
    
}
