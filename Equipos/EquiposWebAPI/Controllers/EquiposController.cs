using EquiposBackend.Dominio;
using EquiposBackend.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquiposWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private IAplicacion app;

        public EquiposController()
        {
            app = new ImpFactoryAplicacion().CrearService();
        }

        //get

        [HttpGet("paises")]
        public IActionResult GetPaises()
        {
            return Ok(app.ConsultarPaises());
        }

        [HttpGet("provincias")]
        public IActionResult GetProvincias()
        {
            return Ok(app.ConsultarProvincias());
        }

        [HttpGet("localidades")]
        public IActionResult GetLocalidades()
        {
            return Ok(app.ConsultarLocalidades());
        }

        [HttpGet("equipos")]
        public IActionResult GetEquipos()
        {
            return Ok(app.ConsultarEquipos());
        }

        [HttpGet("equipos/{id}")]
        public IActionResult GetEquipoByID(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app.ConsultarEquipoByID(id));
        }


        [HttpGet("personas")]
        public IActionResult GetPersonas()
        {
            return Ok(app.ConsultarPersonas());
        }

        [HttpGet("equiposPersonas")]
        public IActionResult GetEquiposPersonas()
        {
            return Ok(app.ConsultarEquipoPersona());
        }


        //post

        [HttpPost("insertarPais")]
        public IActionResult PostPais(string nombre)
        {
            if (nombre == null)
                return BadRequest();
            if (app.CrearPais(nombre))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }


        [HttpPost("insertarProvincia")]
        public IActionResult PostProvincia(string nombre, int idPais)
        {
            if (nombre == null || idPais < 1)
                return BadRequest();
            if (app.CrearProvincia(nombre, idPais))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }

        [HttpPost("insertarLocalidad")]
        public IActionResult PostLocalidad(string nombre, int idProvincia)
        {
            if (nombre == null || idProvincia < 1)
                return BadRequest();
            if (app.CrearLocalidad(nombre, idProvincia))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }

        [HttpPost("insertarPersona")]
        public IActionResult PostPersona(Persona oPersona)
        {
            if (oPersona == null)
                return BadRequest();
            if (app.CrearPersona(oPersona))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }

        [HttpPost("insertarEquipo")]
        public IActionResult PostEquipo(Equipo oEquipo)
        {
            if (oEquipo == null)
                return BadRequest();
            if (app.CrearEquipo(oEquipo))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }

        [HttpPost("insertarEquipoPersona")]
        public IActionResult PostEquipoPersona(EquipoPersona oEP)
        {
            if (oEP == null)
                return BadRequest();
            if (app.CrearEquipoPersona(oEP))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }

        //Put

        [HttpPut("editarPersona")]
        public IActionResult PutPersona(Persona oPersona)
        {
            if (oPersona == null)
                return BadRequest();
            if (app.EditarPersona(oPersona))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }

        [HttpPut("editarEquipo")]
        public IActionResult PutEquipo(Equipo oEquipo)
        {
            if (oEquipo == null)
                return BadRequest();
            if (app.EditarEquipo(oEquipo))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se puedo grabar!");
        }


        //Delete

        [HttpDelete("jugador/{id}")]
        public IActionResult DeleteJugador(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app.EliminarJugador(id));
        }

        [HttpDelete("equipo/{id}")]
        public IActionResult DeleteEquipo(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app.EliminarEquipo(id));
        }


    }
}
