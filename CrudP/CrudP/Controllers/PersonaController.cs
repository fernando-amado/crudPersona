using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace CrudP.Controllers
{
    [RoutePrefix("api/Persona")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PersonaController : ApiController
    {
        [Route("Buscar")]
        [HttpGet]
        public IHttpActionResult BuscarPersona(string buscar)
        {
            return Ok(new N_Persona().ListandoPersona(buscar));
        }
        [Route("Consultar")]
        [HttpGet]
        public IHttpActionResult ConsultarPersona(E_Persona Persona)
        {
            return Ok(new N_Persona().ConsultandoPersona(Persona));
        }
        [HttpPost]

        public IHttpActionResult InsertarCategoria(E_Persona Persona)
        {
            new N_Persona().InsertandoPersona(Persona);
            return StatusCode(HttpStatusCode.Created);
        }
        [HttpPut]

        public IHttpActionResult EditarPersona(E_Persona Persona)
        {
            new N_Persona().EditandoPersona(Persona);
            return StatusCode(HttpStatusCode.Created);
        }
        [HttpDelete]

        public IHttpActionResult EliminarPersona(E_Persona Persona)
        {
            new N_Persona().EliminandoPersona(Persona);
            return StatusCode(HttpStatusCode.Created);
        }
    }
}

