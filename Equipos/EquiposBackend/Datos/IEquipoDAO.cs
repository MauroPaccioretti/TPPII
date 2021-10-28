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
        bool CreateEquipo(Equipo oEquipo);
        bool CreateJugador(Persona oPersona);
        bool CreatePais(string nombrePais);
        bool CreateProvincia(string nombreProvincia, int pais);
        bool CreateLocalidad(string nombreLocalidad, int provincia);
        bool CreateEquipoPersona(EquipoPersona detalle, Equipo oEquipo);
        List<Persona> GetPersonas();
        List<Equipo> GetEquipos();
        List<Pais> GetPaises();
        List<Provincia> GetProvincias();
        List<Localidad> GetLocalidades();
        bool EditEquipo(int idEquipo, Equipo Equipo2);
        bool EditJugador(int idJugador, Jugador Jugador2);
        bool DeleteJugador(int idJugador);
        bool DeleteEquipo(int idEquipo);
    }
}
