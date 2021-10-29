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

            parameters.Add("@cod_persona", detalle.Persona.codPersona);
            parameters.Add("@cod_equipo", oEquipo.CodEquipo);
            parameters.Add("@cod_posicion", detalle.CodPosicion);
            parameters.Add("@camiseta", detalle.Camiseta);


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

        public bool CreateLocalidad(string nombreLocalidad, int provincia)
        {

            bool aux;

            Dictionary<string, Object> parameters = new Dictionary<string, object>();
            parameters.Add("@nombre_localidad", nombreLocalidad);
            parameters.Add("@cod_provincia", provincia);

            aux = helper.addObject("SP_INSERTAR_LOCALIDAD", parameters);

            return aux;
        }

        public bool DeleteEquipo(int idEquipo)
        {
            return helper.DeleteElement(idEquipo, "SP_BAJA_EQUIPO");
        }

        public bool DeleteJugador(int idJugador) // cuando damos de baja a una persona, tenemos que darlo de baja también de EquipoPerosna. Hay q hacerlo via transact!!
        {
            return helper.DeleteElement(idJugador, "SP_BAJA_JUGADOR");
        }

        public bool EditEquipo(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        public bool EditJugador(Jugador jugador)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetPersonas()
        {
            List<Persona> lst = new List<Persona>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_PERSONAS");
            if (dt != null)
            {
                foreach(DataRow row in dt.Rows)
                {
                    Persona oPersona = new Persona();
                    oPersona.codPersona = Convert.ToInt32(row[0].ToString());
                    oPersona.nombre = row[1].ToString();
                    oPersona.apellido = row[2].ToString();
                    oPersona.tipoDoc = Convert.ToInt32(row[3].ToString());
                    oPersona.numeroDoc = Convert.ToInt32(row[4].ToString());
                    oPersona.fechaNac = Convert.ToDateTime(row[5].ToString());
                    oPersona.piernaHabil = Convert.ToInt32(row[6].ToString());
                    oPersona.peso = Convert.ToDouble(row[7].ToString());
                    oPersona.estatura = Convert.ToDouble(row[8].ToString());
                    oPersona.fechaAlta = Convert.ToDateTime(row[9].ToString());
                    if (!row[10].Equals(DBNull.Value))
                        oPersona.fechaBaja = Convert.ToDateTime(row[10].ToString()); 

                    lst.Add(oPersona);

                }

            }

            return lst;
        }

        public List<EquipoPersona> GetEquipoPersona()
        {
            List<EquipoPersona> lst = new List<EquipoPersona>();
            List<Persona> lstPersonas = GetPersonas();
            DataTable dt = helper.GetTable("SP_CONSULTAR_EQUIPOS_PERSONAS");
            if(dt != null)
            {
                foreach(DataRow row in dt.Rows)
                {
                    EquipoPersona oEP = new EquipoPersona();
                    oEP.CodEP = Convert.ToInt32(row[0].ToString());
                    oEP.Persona = lstPersonas.Find(item => item.codPersona == Convert.ToInt32(row[1].ToString()));
                    oEP.CodEquipo = Convert.ToInt32(row[2].ToString());
                    oEP.CodPosicion = Convert.ToInt32(row[3].ToString());
                    oEP.Camiseta = row[4].ToString();
                    oEP.FechaAlta = Convert.ToDateTime(row[5].ToString());
                    if (!row[6].Equals(DBNull.Value))
                        oEP.FechaBaja = Convert.ToDateTime(row[6].ToString());
                }
            }

            return lst;
        }


        public List<Equipo> GetEquipos()
        {
            List<Equipo> lst = new List<Equipo>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_EQUIPOS");
            List<EquipoPersona> lstEP = GetEquipoPersona();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Equipo oEquipo = new Equipo();            
                    oEquipo.CodEquipo = Convert.ToInt32(row[0].ToString());
                    oEquipo.CodLocalidad = Convert.ToInt32(row[1].ToString());
                    oEquipo.Nombre = row[2].ToString();
                    oEquipo.FechaAlta = Convert.ToDateTime(row[3].ToString());
                    if (!row[4].Equals(DBNull.Value))
                        oEquipo.FechaBaja = Convert.ToDateTime(row[4].ToString());
                    if(lstEP.Count > 0)
                        foreach(EquipoPersona oEP in lstEP)
                        {
                            if (oEP.CodEquipo == oEquipo.CodEquipo)
                                oEquipo.AgregarJugador(oEP);
                        }

                    lst.Add(oEquipo);
                       
                }
                return lst;
            }
            

            throw new NotImplementedException();
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
    }
}
