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
    }
}
