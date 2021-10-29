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
        bool CrearPais(string nombrePais);
        bool CrearProvincia(string nombreProvincia, int pais);
        bool CrearLocalidad(string nombreLocalidad, int provincia);
       

        //get - read

        List<Pais> ConsultarPaises();
        List<Provincia> ConsultarProvincias();
        List<Localidad> ConsultarLocalidades();
        List<Persona> ConsultarPersonas();
        List<Equipo> ConsultarEquipos();
        List<EquipoPersona> ConsultarEquipoPersona();
        Equipo ConsultarEquipoByID(int nro);
     

        //update
        bool EditarEquipo(Equipo oEquipo);
        bool EditarPersona(Persona oPersona);

        // delete
        bool EliminarJugador(int nroJugador);
        bool EliminarEquipo(int nroEquipo);





    }
}
