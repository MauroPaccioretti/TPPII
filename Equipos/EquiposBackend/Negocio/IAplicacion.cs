using EquiposBackend.Dominio;
using System.Collections.Generic;

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
        bool CrearTipoDocumento(TiposDocumentos oTipoDoc);
        bool CrearTipoCompromiso(TipoCompromisos oTipoCompromiso);
        bool CrearEquipoFull(Equipo oEquipo);

        //get - read

        List<Pais> ConsultarPaises();
        List<Provincia> ConsultarProvincias();
        List<Localidad> ConsultarLocalidades();
        List<Persona> ConsultarPersonas();
        List<Persona> ConsultarPersonasFiltradas(Dictionary<string, object> filtros);
        List<Equipo> ConsultarEquipos();
        List<EquipoPersona> ConsultarEquipoPersona();
        Equipo ConsultarEquipoByID(int nro);
        List<TiposDocumentos> ConsultarTipoDocumentos();
        List<PiernaHabil> ConsultarPiernaHabil();
        List<TipoCompromisos> ConsultarTiposCompromisos();
        List<Compromiso> ConsultarCompromisos();
        List<Compromiso> ConsultarProximosCompromisos();
        List<Posicion> ConsultarPosiciones();



        //update
        bool EditarEquipo(Equipo oEquipo);
        bool EditarPersona(Persona oPersona);
        bool EditarPais(Pais oPais);
        bool EditarProvincia(Provincia oProvincia);
        bool EditarLocalidad(Localidad oLocalidad);
        bool EditarTipoDocumento(TiposDocumentos oTipoDoc);
        bool EditarTipoCompromiso(TipoCompromisos oTC);
        //bool EditarPosicion(Posicion oPosicion);


        // delete
        bool EliminarPersona(int nroPersona);
        bool EliminarEquipo(int nroEquipo);
        bool QuitarJugadorDelEquipo(int idJugador);

        bool Login(string username, string pass);
        string RecoverPassword(string userRequesting);
        bool CreateUsuario(Usuario usuario);




    }
}
