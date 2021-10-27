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

        public List<Equipo> ConsultarEquipos()
        {
            throw new NotImplementedException();
        }

        public List<Persona> ConsultarPersonas()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo(Equipo oEquipo)
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipoPersona(EquipoPersona detalle, Equipo oEquipo)
        {
            throw new NotImplementedException();
        }

        public bool CrearJugador(Jugador oJugador)
        {
            throw new NotImplementedException();
        }

        public bool CrearLocalidad(string nombreLocalidad, int provincia)
        {
            return dao.CreateLocalidad(nombreLocalidad, provincia);
        }

        public bool CrearPais(string nombrePais)
        {
            return dao.CreatePais(nombrePais);
        }

        public bool CrearProvincia(string nombreProvincia, int pais)
        {
            return dao.CreateProvincia(nombreProvincia, pais);
        }

        public bool EditarEquipo(Equipo oEquipo, Equipo Equipo2)
        {
            throw new NotImplementedException();
        }

        public bool EditarJugador(Jugador oJugador, Jugador Jugador2)
        {
            throw new NotImplementedException();
        }

        public bool EliminarEquipo(Equipo oEquipo)
        {
            throw new NotImplementedException();
        }

        public bool EliminarJugador(Jugador oJugador)
        {
            throw new NotImplementedException();
        }

        public List<Localidad> ConsultarLocalidades()
        {
            return dao.GetLocalidades();
        }

        public List<Pais> ConsultarPaises()
        {
            return dao.GetPaises();
        }

        public List<Provincia> ConsultarProvincias()
        {
            return dao.GetProvincias();
        }
    }
}
