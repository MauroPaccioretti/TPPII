using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Negocio
{
    public interface IAplicacion
    {
        //crear
        bool CrearEquipo(Equipo oEquipo);
        bool CrearPersona(Persona oPersona);
        bool CrearEquipoPersona(EquipoPersona detalle);
        bool CrearPais(Pais oPais);
        bool CrearProvincia(Provincia oProvincia);
        bool CrearLocalidad(Localidad oLocalidad);
       

        //get - read

        List<Pais> ConsultarPaises();
        List<Provincia> ConsultarProvincias();
        List<Localidad> ConsultarLocalidades();
        List<Persona> ConsultarPersonas();
        List<Equipo> ConsultarEquipos();
        List<EquipoPersona> ConsultarEquipoPersona();
        Equipo ConsultarEquipoByID(int nro);
        List<TiposDocumentos> ConsultarTipoDocumentos();
        List<PiernaHabil> ConsultarPiernaHabil();
        List<TipoCompromisos> ConsultarTiposCompromisos();
        List<Compromiso> ConsultarCompromisos();
        List<Compromiso> ConsultarProximosCompromisos();


        //update
        bool EditarEquipo(Equipo oEquipo);
        bool EditarPersona(Persona oPersona);

        // delete
        bool EliminarPersona(int nroPersona);
        bool EliminarEquipo(int nroEquipo);
        bool QuitarJugadorDelEquipo(int idJugador);

        bool Login(string username, string pass);
        string RecoverPassword(string userRequesting);
        bool CreateUsuario(Usuario usuario);



    }
}
