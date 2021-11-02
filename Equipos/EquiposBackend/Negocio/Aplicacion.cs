using EquiposBackend.Datos;
using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Negocio
{
    public class Aplicacion : IAplicacion
    {
        EquipoDAO dao = new EquipoDAO();
        UsuariosDao usuariosDao = new UsuariosDao();


        //create
        
        public bool CrearEquipo(Equipo oEquipo)
        {
            return dao.CreateEquipo(oEquipo);
        }
        public bool CrearPersona(Persona oPersona)
        {
            return dao.CreatePersona(oPersona);
        }

        public bool CrearEquipoPersona(EquipoPersona detalle)
        {
            return dao.CreateEquipoPersona(detalle);
        }

        public bool CrearPais(string nombrePais)
        {
            return dao.CreatePais(nombrePais);
        }

        public bool CrearProvincia(string nombreProvincia, int pais)
        {
            return dao.CreateProvincia(nombreProvincia, pais);
        }

        public bool CrearLocalidad(string nombreLocalidad, int provincia)
        {
            return dao.CreateLocalidad(nombreLocalidad, provincia);
        }

        //get - read


        public List<Pais> ConsultarPaises()
        {
            return dao.GetPaises();
        }

        public List<Provincia> ConsultarProvincias()
        {
            return dao.GetProvincias();
        }

        public List<Localidad> ConsultarLocalidades()
        {
            return dao.GetLocalidades();
        }

        public List<Persona> ConsultarPersonas()
        {
            return dao.GetPersonas();
        }
        public List<Equipo> ConsultarEquipos()
        {
            return dao.GetEquipos();
        }

        public List<EquipoPersona> ConsultarEquipoPersona()
        {
            return dao.GetEquipoPersona();
        }

        public Equipo ConsultarEquipoByID(int nro)
        {
            return dao.GetEquipoByID(nro);
        }

        public List<TiposDocumentos> ConsultarTipoDocumentos()
        {
            return dao.GetTiposDocumentos();
        }
        public List<PiernaHabil> ConsultarPiernaHabil()
        {
            return dao.GetPiernaHabil();
        }
        public List<TipoCompromisos> ConsultarTiposCompromisos()
        {
            return dao.GetTiposCompromisos();
        }
        public List<Compromiso> ConsultarCompromisos()
        {
            return dao.GetCompromisos();
        }
        public List<Compromiso> ConsultarProximosCompromisos()
        {
            return dao.GetProximosCompromisos();
        }


        //update

        public bool EditarEquipo(Equipo oEquipo)
        {
            return dao.EditEquipo(oEquipo);
        }
        public bool EditarPersona(Persona oPersona)
        {
            return dao.EditPersona(oPersona);
        }

        // delete 

        public bool EliminarPersona(int nroPersona)
        {
            return dao.DeletePersona(nroPersona);
        }

        public bool EliminarEquipo(int nroEquipo)
        {
            return dao.DeleteEquipo(nroEquipo);
        }

        public bool QuitarJugadorDelEquipo(int codJugador)
        {
            return dao.RemoveJugadorDelEquipo(codJugador);
        }


        // LOGIN

        public bool Login(string username, string pass)
        {
           return usuariosDao.Login(username, pass);
        }

        public string RecoverPassword(string userRequesting)
        {
            return usuariosDao.RecoverPassword(userRequesting);
        }

        public bool CreateUsuario(Usuario usuario)
        {
            return usuariosDao.CreateUsuario(usuario);
        }
    }
}
