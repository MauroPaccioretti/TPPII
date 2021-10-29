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

        public bool EliminarJugador(int nroJugador)
        {
            return dao.DeleteJugador(nroJugador);
        }

        public bool EliminarEquipo(int nroEquipo)
        {
            return dao.DeleteEquipo(nroEquipo);
        }

        
        

        
    }
}
