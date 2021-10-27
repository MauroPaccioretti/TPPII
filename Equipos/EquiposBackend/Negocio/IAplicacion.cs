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
        public bool CrearEquipo(Equipo oEquipo);
        public bool CrearJugador(Jugador oJugador);
        public List<Persona> ConsultarPersonas();
        public List<Equipo> ConsultarEquipos();


        bool CrearPais(string nombrePais);
        bool CrearProvincia(string nombreProvincia, int pais);
        bool CrearLocalidad(string nombreLocalidad, int provincia);
        bool CrearEquipoPersona(EquipoPersona detalle, Equipo oEquipo);

        List<Pais> ConsultarPaises();
        List<Provincia> ConsultarProvincias();
        List<Localidad> ConsultarLocalidades();
        bool EditarEquipo(Equipo oEquipo, Equipo Equipo2);
        bool EditarJugador(Jugador oJugador, Jugador Jugador2);
        bool EliminarJugador(Jugador oJugador);
        bool EliminarEquipo(Equipo oEquipo);





    }
}
