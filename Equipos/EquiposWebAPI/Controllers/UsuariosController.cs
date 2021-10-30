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
    public class UsuariosController : ControllerBase
    {
        private IAplicacion app;

        public UsuariosController()
        {
            app = new ImpFactoryAplicacion().CrearService();
        }

       
        [HttpPost("login")]
        public IActionResult GetLogin(List <string> lst )
        {            
            string usser = lst[0];
            string password = lst[1];
            return Ok(app.Login(usser, password));
        }

        [HttpGet("recoverPass")]
        public IActionResult GetPass(string userRequesting)
        {
            return Ok(app.RecoverPassword(userRequesting));
        }

    }
}
