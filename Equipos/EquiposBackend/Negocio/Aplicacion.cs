using EquiposBackend.Datos;
using EquiposBackend.Dominio;
using System.Collections.Generic;
using System.Data;

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

        public bool CrearPais(Pais oPais)
        {
            return dao.CreatePais(oPais);
        }

        public bool CrearProvincia(Provincia oProvincia)
        {
            return dao.CreateProvincia(oProvincia);
        }

        public bool CrearLocalidad(Localidad oLocalidad)
        {
            return dao.CreateLocalidad(oLocalidad);
        }


        public bool CrearTipoDocumento(TiposDocumentos oTipoDoc)
        {
            return dao.CreateTipoDocumento(oTipoDoc);
        }
        public bool CrearTipoCompromiso(TipoCompromisos oTipoCompromiso)
        {
            return dao.CreateTipoCompromiso(oTipoCompromiso);
        }

        public bool CreateCompromiso(Compromiso compromiso)
        {
            return dao.CreateCompromiso(compromiso);
        }

        public bool CrearEquipoFull(Equipo oEquipo)
        {
            return dao.CreateEquipoFull(oEquipo);
        }



        //get - read
        public DataTable ConsultarEquiposForDisplay(bool full)
        {
            return dao.GetEquiposForDisplay(full);
        }

        public DataTable ConsultarCompromisosForDisplay(bool full)
        {
            return dao.GetCompromisosForDisplay(full);

        }

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

        public List<Persona> ConsultarPersonasFiltradas(Dictionary<string, object> filtros)
        {
            return dao.GetPersonasFiltered(filtros);
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

        public List<Posicion> ConsultarPosiciones()
        {
            return dao.GetPosiciones();
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


        public bool EditarEquipoPersona(EquipoPersona oEP)
        {
            return dao.EditEquipoPersona(oEP);
        }
        public bool EditarPais(Pais oPais)
        {
            return dao.EditPais(oPais);
        }
        public bool EditarProvincia(Provincia oProvincia)
        {
            return dao.EditProvincia(oProvincia);
        }

        public bool EditarLocalidad(Localidad oLocalidad)
        {
            return dao.EditLocalidad(oLocalidad);
        }

        public bool EditarTipoDocumento(TiposDocumentos oTipoDoc)
        {
            return dao.EditTipoDocumento(oTipoDoc);
        }

        public bool EditarTipoCompromiso(TipoCompromisos oTC)
        {
            return dao.EditTipoCompromiso(oTC);
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

        public bool EliminarCompromiso(int idCompromiso)
        {
            return dao.DeleteCompromiso(idCompromiso);
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
