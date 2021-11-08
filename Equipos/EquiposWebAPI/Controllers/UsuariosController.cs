using EquiposBackend.Dominio;
using EquiposBackend.Negocio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EquiposWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IAplicacion app;

        public UsuariosController()
        {
            app = new ImpFactoryAplicacion().CrearService();
        }


        [HttpPost("login")]
        public IActionResult GetLogin(List<string> lst)
        {
            string usser = lst[0];
            string password = lst[1];
            return Ok(app.Login(usser, password));
        }

        //[HttpPost("register")]
        //public IActionResult PostEquipo(Usuario usuario)
        //{
        //    if (usuario == null)
        //        return BadRequest();
        //    if (app.CreateUsuario(usuario))
        //        return Ok("Se registró exitosamente!");
        //    else
        //        return Ok("No se puedo grabar!");
        //}

        [HttpPost("register")]
        public IActionResult PostUsuario(Usuario usuario)
        {
            if (usuario == null)
                return BadRequest();
            if (app.CreateUsuario(usuario))
                return Ok("Se registró exitosamente!");
            else
                return Ok("No se pudo grabar!");
        }

        [HttpGet("recoverPass")]
        public IActionResult GetPass(string userRequesting)
        {
            return Ok(app.RecoverPassword(userRequesting));
        }

    }
}
