using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Localidad> GetLocalidades()
        {
            List<Provincia> lstProvincia = GetProvincias();
            List<Localidad> lst = new List<Localidad>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_LOCALIDADES");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Localidad oLocalidad = new Localidad();
                    oLocalidad.IDLocalidad = Convert.ToInt32(row[0].ToString());
                    oLocalidad.Nombre = row[1].ToString();
                    oLocalidad.Provincia = lstProvincia[Convert.ToInt32(row[2].ToString()) - 1];
                    //oLocalidad.Provincia.IDProvincia = Convert.ToInt32(row[2].ToString());
                    lst.Add(oLocalidad);
                }
            }
            return lst;
        }

        public List<Pais> GetPaises()
        {
            List<Pais> lst = new List<Pais>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_PAISES");
            if(dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Pais oPais = new Pais();
                    oPais.IDPais = Convert.ToInt32(row[0].ToString());
                    oPais.Nombre = row[1].ToString();
                    lst.Add(oPais);
                }
            }
            return lst;
            
        }

        public List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }

        public List<Provincia> GetProvincias()
        {
            List<Provincia> lst = new List<Provincia>();

            List<Pais> lstPaises = new();

            DataTable dtPaises = helper.GetTable("SP_CONSULTAR_PAISES");
            if (dtPaises != null)
            {
                foreach (DataRow row in dtPaises.Rows)
                {
                    Pais oPais = new Pais();
                    oPais.IDPais = Convert.ToInt32(row[0].ToString());
                    oPais.Nombre = row[1].ToString();
                    lstPaises.Add(oPais);
                }
            }

            DataTable dt = helper.GetTable("SP_CONSULTAR_PROVINCIAS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Provincia oProvincia = new Provincia();
                    oProvincia.IDProvincia = Convert.ToInt32(row[0].ToString());
                    oProvincia.Nombre = row[1].ToString();
                    oProvincia.Pais = lstPaises[Convert.ToInt32(row[2].ToString()) - 1];
                    //oProvincia.Pais.IDPais = Convert.ToInt32(row[2].ToString());
                    lst.Add(oProvincia);
                }
            }
            return lst;
        }
    }
}
