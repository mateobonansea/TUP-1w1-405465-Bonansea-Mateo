using Microsoft.AspNetCore.Mvc;
using PrimeraWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrimeraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private static List<Moneda> listaMoneda =new List<Moneda>();


        // GET: api/<Moneda1Controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(listaMoneda);
                
        }

        // GET api/<Moneda1Controller>/5
        [HttpGet("{Nombre}")]
        public IActionResult Get(string Nombre)
        {
            foreach (Moneda m in listaMoneda)
            {
                if(m.Nombre == Nombre)
                {
                    return Ok(m);
                }
            }
            return NotFound("Moneda inexistente");
        }

        // POST api/<Moneda1Controller>
        [HttpPost]
        public IActionResult Post([FromBody] Moneda m)
        {
            if ( m.Nombre!= string.Empty)
            {
                listaMoneda.Add(m);
                return Ok(m);
            }
           return BadRequest("Moneda incorrecta o sin valor");

           

        }

        // PUT api/<Moneda1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Moneda1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
