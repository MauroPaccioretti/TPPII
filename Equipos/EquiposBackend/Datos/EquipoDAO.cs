using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Datos
{
    class EquipoDAO : IEquipoDAO
    {
        HelperDAO helper = HelperDAO.GetInstance();

        public bool CreateEquipo(Equipo oEquipo)
        {
            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre", oEquipo.nombre);

            aux = helper.addObject("SP_INSERTAR_EQUIPO", parameters);

            return aux;
        }

        public bool CreateEquipoPersona(EquipoPersona detalle, Equipo oEquipo)
        {

            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@cod_persona", detalle.persona.codPersona);
            parameters.Add("@cod_equipo", oEquipo.codEquipo);
            parameters.Add("@cod_posicion", detalle.codPosicion);
            parameters.Add("@camiseta", detalle.camiseta);


            aux = helper.addObject("SP_INSERTAR_EQUIPOS_PERSONAS", parameters);

            return aux;

        }



        public bool CreateJugador(Persona oPersona)
        {

            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre", oPersona.nombre);
            parameters.Add("@apellido", oPersona.apellido);
            parameters.Add("@cod_tipoDoc", oPersona.tipoDoc);
            parameters.Add("@numeroDocumento", oPersona.numeroDoc);
            parameters.Add("@fechaNac", oPersona.fechaNac);
            parameters.Add("@piernaHabil", oPersona.piernaHabil);
            parameters.Add("@peso", oPersona.peso);
            parameters.Add("@estatura", oPersona.estatura);


            aux = helper.addObject("SP_INSERTAR_PERSONA", parameters);

            return aux;
        }

        public bool CreateLocalidad(string nombreLocalidad, int provincia)
        {

            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre_localidad", nombreLocalidad);
            parameters.Add("@cod_provincia", provincia);

            aux = helper.addObject("SP_INSERTAR_LOCALIDAD", parameters);

            return aux;
        }

        public bool CreatePais(string nombrePais)
        {
            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre_pais", nombrePais);

            aux = helper.addObject("SP_INSERTAR_PAIS", parameters);

            return aux;

        }

        public bool CreateProvincia(string nombreProvincia, int pais)
        {
            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre_provincia", nombreProvincia);
            parameters.Add("@cod_pais", pais);

            aux = helper.addObject("SP_INSERTAR_PROVINCIA", parameters);

            return aux;
        }

        public bool DeleteEquipo(Equipo oEquipo)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJugador(Jugador oJugador)
        {
            throw new NotImplementedException();
        }

        public bool EditEquipo(Equipo oEquipo, Equipo Equipo2)
        {
            throw new NotImplementedException();
        }

        public bool EditJugador(Jugador oJugador, Jugador Jugador2)
        {
            throw new NotImplementedException();
        }

        public List<Equipo> GetEquipos()
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }
    }
}
