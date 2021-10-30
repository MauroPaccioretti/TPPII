using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Datos
{
    interface IEquipoDAO
    {
        //create
        bool CreateEquipo(Equipo oEquipo);
        bool CreatePersona(Persona oPersona);
        bool CreateEquipoPersona(EquipoPersona detalle);
        bool CreatePais(string nombrePais);
        bool CreateProvincia(string nombreProvincia, int pais);
        bool CreateLocalidad(string nombreLocalidad, int provincia);


        //get - read
        List<Persona> GetPersonas();
        List<EquipoPersona> GetEquipoPersona();
        List<Equipo> GetEquipos();
        Equipo GetEquipoByID(int nro);
        List<Pais> GetPaises();
        List<Provincia> GetProvincias();
        List<Localidad> GetLocalidades();
        List<TiposDocumentos> GetTiposDocumentos();
        List<PiernaHabil> GetPiernaHabil();
        List<TipoCompromisos> GetTiposCompromisos();
        List<Compromiso> GetCompromisos();
        List<Compromiso> GetProximosCompromisos();


        //update
        bool EditEquipo(Equipo equipo);
        bool EditPersona(Persona oPersona);

        //delete
        bool DeletePersona(int idPersona);
        bool DeleteEquipo(int idEquipo);
        bool RemoveJugadorDelEquipo(int idJugador);
    }
}
