using EquiposBackend.Dominio;
using EquiposBackend.Negocio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet("tipoDocumentos")]
        public IActionResult GetTipoDocumentos()
        {
            return Ok(app.ConsultarTipoDocumentos());
        }

        [HttpGet("piernaHabil")]
        public IActionResult GetPiernaHabil()
        {
            return Ok(app.ConsultarPiernaHabil());
        }

        [HttpGet("posiciones")]
        public IActionResult GetPosiciones()
        {
            return Ok(app.ConsultarPosiciones());
        }


        [HttpGet("tipoCompromisos")]
        public IActionResult GetTiposCompromisos()
        {
            return Ok(app.ConsultarTiposCompromisos());
        }

        [HttpGet("compromisos")]
        public IActionResult GetCompromisos()
        {
            return Ok(app.ConsultarCompromisos());
        }

        [HttpGet("proximosCompromisos")]
        public IActionResult GetProximosCompromisos()
        {
            return Ok(app.ConsultarProximosCompromisos());
        }


        //post

        [HttpPost("crearEquipoFull")]
        public IActionResult PostEquipoFull(Equipo oEquipo)
        {
            if (oEquipo == null)
                return BadRequest();
            if (app.CrearEquipoFull(oEquipo))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");

        }

        [HttpPost("consultarPersonasConFiltro")]
        public IActionResult PostGetPersonasFiltradas(Dictionary<string,object> filtros)
        {
            return Ok(app.ConsultarPersonasFiltradas(filtros));
            
        }


        [HttpPost("insertarPais")]
        public IActionResult PostPais(Pais oPais)
        {
            if (oPais == null)
                return BadRequest();
            if (app.CrearPais(oPais))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }


        [HttpPost("insertarProvincia")]
        public IActionResult PostProvincia(Provincia oProvincia)
        {
            if (oProvincia == null)
                return BadRequest();
            if (app.CrearProvincia(oProvincia))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpPost("insertarLocalidad")]
        public IActionResult PostLocalidad(Localidad oLocalidad)
        {
            if (oLocalidad == null)
                return BadRequest();
            if (app.CrearLocalidad(oLocalidad))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpPost("insertarTipoDocumento")]
        public IActionResult PostTipoDocumento(TiposDocumentos oTipoDoc)
        {
            if (oTipoDoc == null)
                return BadRequest();
            if (app.CrearTipoDocumento(oTipoDoc))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpPost("insertarTipoCompromiso")]
        public IActionResult PostTipoCompromiso(TipoCompromisos oTipoComp)
        {
            if (oTipoComp == null)
                return BadRequest();
            if (app.CrearTipoCompromiso(oTipoComp))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }


        [HttpPost("insertarPersona")]
        public IActionResult PostPersona(Persona oPersona)
        {
            if (oPersona == null)
                return BadRequest();
            if (app.CrearPersona(oPersona))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpPost("insertarEquipo")]
        public IActionResult PostEquipo(Equipo oEquipo)
        {
            if (oEquipo == null)
                return BadRequest();
            if (app.CrearEquipo(oEquipo))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpPost("insertarEquipoPersona")]
        public IActionResult PostEquipoPersona(EquipoPersona oEP)
        {
            if (oEP == null)
                return BadRequest();
            if (app.CrearEquipoPersona(oEP))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
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
                return Ok("No se pudo grabar!");
        }

        [HttpPut("editarEquipo")]
        public IActionResult PutEquipo(Equipo oEquipo)
        {
            if (oEquipo == null)
                return BadRequest();
            if (app.EditarEquipo(oEquipo))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpPut("editarPais")]
        public IActionResult PutPais(Pais oPais)
        {
            if (oPais == null)
                return BadRequest();
            if (app.EditarPais(oPais))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpPut("editarProvincia")]
        public IActionResult PutProvincia(Provincia oProvincia)
        {
            if (oProvincia == null)
                return BadRequest();
            if (app.EditarProvincia(oProvincia))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }


        [HttpPut("editarLocalidad")]
        public IActionResult PutLocalidad(Localidad oLocalidad)
        {
            if (oLocalidad == null)
                return BadRequest();
            if (app.EditarLocalidad(oLocalidad))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }


        [HttpPut("editarTipoDocumento")]
        public IActionResult PutTipoDocumento(TiposDocumentos oTipoDoc)
        {
            if (oTipoDoc == null)
                return BadRequest();
            if (app.EditarTipoDocumento(oTipoDoc))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }


        [HttpPut("editarTipoCompromisos")]
        public IActionResult PutTipoCompromisos(TipoCompromisos oTC)
        {
            if (oTC == null)
                return BadRequest();
            if (app.EditarTipoCompromiso(oTC))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }


        //Delete

        [HttpDelete("persona/{id}")]
        public IActionResult DeletePersona(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app.EliminarPersona(id));
        }

        [HttpDelete("equipo/{id}")]
        public IActionResult DeleteEquipo(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app.EliminarEquipo(id));
        }

        [HttpDelete("jugador/{id}")]
        public IActionResult DeleteJugador(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app.QuitarJugadorDelEquipo(id));
        }

    }
}
