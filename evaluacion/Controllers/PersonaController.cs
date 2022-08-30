using Microsoft.AspNetCore.Mvc;
using evaluacion.Model;

namespace evaluacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpPost("Lista")]
        public async Task<IActionResult> Lista(ListaPersonaModel persona)
        {
            try
            {
                if (persona.ListaPersona == null)
                    return Ok("La lista no puede ser nula.");

                if (persona.ListaPersona.Count <= 0)
                    return Ok("La lista no contiene ningún registro.");

                List<string> ListaPersona = new List<string>();

                foreach (var item in persona.ListaPersona)
                {
                    if (item.Sexo.Equals("F"))
                        if (item.Edad>=18)
                            ListaPersona.Add(item.Nombre + " " + item.Apellido);
                }

                return Ok(ListaPersona);
            }
            catch (Exception err)
            {
                return Ok(err.Message.ToString());
            }

        }
    }
}

