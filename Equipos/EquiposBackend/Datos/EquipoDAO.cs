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

            parameters.Add("@nombre", oEquipo.Nombre);

            aux = helper.addObject("SP_INSERTAR_EQUIPO", parameters);

            return aux;
        }

        public bool CreateEquipoPersona(EquipoPersona detalle, Equipo oEquipo)
        {
            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();

            parameters.Add("@cod_persona", detalle.persona.codPersona);
            parameters.Add("@cod_equipo", oEquipo.CodEquipo);
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

        public bool DeleteEquipo(int idEquipo)
        {
            return helper.DeleteElement(idEquipo, "SP_ELIMINAR_EQUIPO");
        }

        public bool DeleteJugador(int idJugador)
        {
            return helper.DeleteElement(idJugador, "SP_ELIMINAR_JUGADOR");
        }

        public bool EditEquipo(int idEquipo, Equipo Equipo2)
        {
            throw new NotImplementedException();
        }

        public bool EditJugador(int idJugador, Jugador Jugador2)
        {
            throw new NotImplementedException();
        }

        public List<Equipo> GetEquipos()
        {
            List<Equipo> lst = new List<Equipo>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_EQUIPOS_ACTIVOS");
            bool bandera = true;
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Equipo oEquipo = new Equipo();
                    Persona oPersona = new Persona();
                    EquipoPersona oDetalle = new EquipoPersona();
                    if (bandera) 
                    {                    
                        oEquipo.CodEquipo = Convert.ToInt32(row[0].ToString());
                        oEquipo.CodLocalidad = Convert.ToInt32(row[1].ToString());
                        oEquipo.Nombre = row[2].ToString();
                        oEquipo.FechaAlta = Convert.ToDateTime(row[3].ToString());
                        
                        //falta terminar
                        //hay que pensar cómo hacemos el SP.. si traemos equipos join equiposPersonas join personas, u otra cosa.

                    }
                }
            }

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
                    oLocalidad.Provincia = lstProvincia.Find(item => item.IDProvincia == Convert.ToInt32(row[2].ToString()));
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

            List<Pais> lstPaises = GetPaises();

            DataTable dt = helper.GetTable("SP_CONSULTAR_PROVINCIAS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Provincia oProvincia = new Provincia();
                    oProvincia.IDProvincia = Convert.ToInt32(row[0].ToString());
                    oProvincia.Nombre = row[1].ToString();
                    oProvincia.Pais = lstPaises.Find(item => item.IDPais == Convert.ToInt32(row[2].ToString()));
                    //oProvincia.Pais.IDPais = Convert.ToInt32(row[2].ToString());
                    lst.Add(oProvincia);
                }
            }
            return lst;
        }
    }
}
