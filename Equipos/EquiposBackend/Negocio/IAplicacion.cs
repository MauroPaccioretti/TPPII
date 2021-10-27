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
    }
}
