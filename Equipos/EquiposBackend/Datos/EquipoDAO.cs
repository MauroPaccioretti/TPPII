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

        //create

        public bool CreateEquipo(Equipo oEquipo)
        {
            bool aux;

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre", oEquipo.Nombre);

            aux = helper.addObject("SP_INSERTAR_EQUIPO", parameters);

            return aux;
        }

        public bool CreateEquipoFull(Equipo oEquipo)
        {
            return helper.CrearEquipo(oEquipo);
        }

        public bool CreatePersona(Persona oPersona)
        {
            bool aux;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nombre", oPersona.Nombre);
            parameters.Add("@apellido", oPersona.Apellido);
            parameters.Add("@cod_tipoDoc", oPersona.TipoDoc);
            parameters.Add("@numeroDocumento", oPersona.NumeroDoc);
            parameters.Add("@fechaNac", oPersona.FechaNac);
            parameters.Add("@piernaHabil", oPersona.PiernaHabil);
            parameters.Add("@peso", oPersona.Peso);
            parameters.Add("@estatura", oPersona.Estatura);

            aux = helper.addObject("SP_INSERTAR_PERSONA", parameters);

            return aux;
        }

        public bool CreateEquipoPersona(EquipoPersona detalle)
        {
            bool aux;

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@cod_persona", detalle.Persona.CodPersona);
            parameters.Add("@cod_equipo", detalle.CodEquipo);
            parameters.Add("@cod_posicion", detalle.CodPosicion);
            parameters.Add("@camiseta", detalle.Camiseta);


            aux = helper.addObject("SP_INSERTAR_EQUIPOS_PERSONAS", parameters);

            return aux;

        }

        public bool CreatePais(Pais oPais)
        {
            bool aux;
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre_pais", oPais.Nombre);

            aux = helper.addObject("SP_INSERTAR_PAIS", parameters);

            return aux;

        }

        public bool CreateProvincia(Provincia oProvincia)
        {
            bool aux;

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@nombre_provincia", oProvincia.Nombre);
            parameters.Add("@cod_pais", oProvincia.Pais.IDPais);

            aux = helper.addObject("SP_INSERTAR_PROVINCIA", parameters);

            return aux;
        }

        public bool CreateLocalidad(Localidad oLocalidad)
        {

            bool aux;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nombre_localidad", oLocalidad.Nombre);
            parameters.Add("@cod_provincia", oLocalidad.Provincia.IDProvincia);

            aux = helper.addObject("SP_INSERTAR_LOCALIDAD", parameters);

            return aux;
        }

        public bool CreateTipoDocumento(TiposDocumentos oTipoDoc)
        {
            bool aux;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tipoDoc", oTipoDoc.TipoDoc);
            

            aux = helper.addObject("SP_INSERTAR_TIPO_DOC", parameters);

            return aux;

        }

        public bool CreateTipoCompromiso(TipoCompromisos oTipoCompromiso)
        {
            bool aux;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tipo", oTipoCompromiso.NombreCompromiso);


            aux = helper.addObject("SP_INSERTAR_TIPO_COMPROMISO", parameters);

            return aux;
        }




        ////get - read


        public DataTable GetEquiposForDisplay(bool full)
        {
            DataTable dt = new DataTable();
            if (!full)
                dt = helper.GetTable("SP_CONSULTAR_EQUIPOS_CON_COLUMNAS");
            if (full)
                dt = helper.GetTable("SP_CONSULTAR_EQUIPOS_CON_COLUMNAS_SINFILTROS");
            return dt;
        }

        public DataTable GetCompromisosForDisplay(bool full)
        {
            DataTable dt = new DataTable();
            if (!full)
                dt = helper.GetTable("SP_CONSULTAR_COMPROMISOS_CON_COLUMNAS");
            if (full)
                dt = helper.GetTable("SP_CONSULTAR_COMPROMISOS_CON_COLUMNAS_SINFILTRO");
            return dt;
        }

        public List<Persona> GetPersonas()
        {
            List<Persona> lst = new List<Persona>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_PERSONAS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Persona oPersona = new Persona();
                    oPersona.CodPersona = Convert.ToInt32(row[0].ToString());
                    oPersona.Nombre = row[1].ToString();
                    oPersona.Apellido = row[2].ToString();
                    oPersona.TipoDoc = Convert.ToInt32(row[3].ToString());
                    oPersona.NumeroDoc = Convert.ToInt32(row[4].ToString());
                    oPersona.FechaNac = Convert.ToDateTime(row[5].ToString());
                    oPersona.PiernaHabil = Convert.ToInt32(row[6].ToString());
                    oPersona.Peso = Convert.ToDouble(row[7].ToString());
                    oPersona.Estatura = Convert.ToDouble(row[8].ToString());
                    oPersona.FechaAlta = Convert.ToDateTime(row[9].ToString());
                    if (!row[10].Equals(DBNull.Value))
                        oPersona.FechaBaja = Convert.ToDateTime(row[10].ToString());

                    lst.Add(oPersona);

                }

            }

            return lst;
        }

        public List<Persona> GetPersonasFiltered(Dictionary<string, object> filtros)
        {
            List<Persona> lst = new List<Persona>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_PERSONAS_CONFILTRO", filtros);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Persona oPersona = new Persona();
                    oPersona.CodPersona = Convert.ToInt32(row[0].ToString());
                    oPersona.Nombre = row[1].ToString();
                    oPersona.Apellido = row[2].ToString();
                    oPersona.TipoDoc = Convert.ToInt32(row[3].ToString());
                    oPersona.NumeroDoc = Convert.ToInt32(row[4].ToString());
                    oPersona.FechaNac = Convert.ToDateTime(row[5].ToString());
                    oPersona.PiernaHabil = Convert.ToInt32(row[6].ToString());
                    oPersona.Peso = Convert.ToDouble(row[7].ToString());
                    oPersona.Estatura = Convert.ToDouble(row[8].ToString());
                    oPersona.FechaAlta = Convert.ToDateTime(row[9].ToString());
                    if (!row[10].Equals(DBNull.Value))
                        oPersona.FechaBaja = Convert.ToDateTime(row[10].ToString());

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
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    EquipoPersona oEP = new EquipoPersona();
                    oEP.CodEP = Convert.ToInt32(row[0].ToString());
                    oEP.Persona = lstPersonas.Find(item => item.CodPersona == Convert.ToInt32(row[1].ToString()));
                    oEP.CodEquipo = Convert.ToInt32(row[2].ToString());
                    oEP.CodPosicion = Convert.ToInt32(row[3].ToString());
                    oEP.Camiseta = row[4].ToString();
                    oEP.FechaAlta = Convert.ToDateTime(row[5].ToString());
                    if (!row[6].Equals(DBNull.Value))
                        oEP.FechaBaja = Convert.ToDateTime(row[6].ToString());
                    lst.Add(oEP);
                }
            }
            return lst;
        }

        public List<Equipo> GetEquipos()
        {
            List<Equipo> lst = new List<Equipo>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_EQUIPOS");
            List<EquipoPersona> lstEP = GetEquipoPersona();
            List<Compromiso> lstCompromiso = GetCompromisos();
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
                    if (lstEP != null)
                        foreach (EquipoPersona oEP in lstEP)
                        {
                            if (oEP.CodEquipo == oEquipo.CodEquipo)
                                oEquipo.AgregarJugador(oEP);
                        }
                    if(lstCompromiso != null)
                    {
                        foreach(Compromiso oComp in lstCompromiso)
                        {
                            if (oComp.CodEquipo == oEquipo.CodEquipo)
                                oEquipo.AgregarCompromiso(oComp);
                        }
                    }

                    lst.Add(oEquipo);
                }


            }
            return lst;
        }

        public Equipo GetEquipoByID(int nro)
        {
            Equipo oEquipo = new Equipo();

            DataTable dt = helper.GetTable("SP_CONSULTAR_EQUIPOS_POR_ID", new Dictionary<string, object> { { "@codigo", nro } });
            bool bandera = true;
            if (dt != null)
                foreach (DataRow row in dt.Rows)
                {
                    if (bandera)
                    {
                        oEquipo.CodEquipo = Convert.ToInt32(row[0].ToString());
                        oEquipo.CodLocalidad = Convert.ToInt32(row[1].ToString());
                        oEquipo.Nombre = row[2].ToString();
                        oEquipo.FechaAlta = Convert.ToDateTime(row[3].ToString());
                        if (!row[4].Equals(DBNull.Value))
                            oEquipo.FechaBaja = Convert.ToDateTime(row[4].ToString());
                        bandera = false;
                    }

                    EquipoPersona oEP = new EquipoPersona();
                    Persona oPersona = new Persona();

                    oEP.CodEP = Convert.ToInt32(row[5].ToString());
                    oEP.CodPosicion = Convert.ToInt32(row[8].ToString());
                    oEP.Camiseta = row[9].ToString();
                    oEP.FechaAlta = Convert.ToDateTime(row[10]);
                    if (!row[11].Equals(DBNull.Value))
                        oEP.FechaBaja = Convert.ToDateTime(row[11].ToString());

                    oPersona.CodPersona = Convert.ToInt32(row[12].ToString());
                    oPersona.Nombre = row[13].ToString();
                    oPersona.Apellido = row[14].ToString();
                    oPersona.TipoDoc = Convert.ToInt32(row[15].ToString());
                    oPersona.NumeroDoc = Convert.ToInt32(row[16].ToString());
                    oPersona.FechaNac = Convert.ToDateTime(row[17].ToString());
                    oPersona.PiernaHabil = Convert.ToInt32(row[18].ToString());
                    oPersona.Peso = Convert.ToDouble(row[19].ToString());
                    oPersona.Estatura = Convert.ToDouble(row[20].ToString());
                    oPersona.FechaAlta = Convert.ToDateTime(row[21].ToString());
                    if (!row[22].Equals(DBNull.Value))
                        oPersona.FechaBaja = Convert.ToDateTime(row[22].ToString());

                    oEP.Persona = oPersona;

                    oEquipo.AgregarJugador(oEP);
                }

            return oEquipo;
        }

        public List<Pais> GetPaises()
        {
            List<Pais> lst = new List<Pais>();
            DataTable dt = helper.GetTable("SP_CONSULTAR_PAISES");
            if (dt != null)
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

        public List<TiposDocumentos> GetTiposDocumentos()
        {
            List<TiposDocumentos> lst = new();
            DataTable dt = helper.GetTable("SP_CONSULTAR_TIPOS_DOC");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TiposDocumentos oTdD = new TiposDocumentos();
                    oTdD.CodTipoDoc = Convert.ToInt32(row[0].ToString());
                    oTdD.TipoDoc = row[1].ToString();
                    
                    lst.Add(oTdD);

                }
            }
            return lst;
        }

        public List<PiernaHabil> GetPiernaHabil()
        {
            List<PiernaHabil> lst = new();
            DataTable dt = helper.GetTable("SP_CONSULTAR_PIERNAS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    PiernaHabil oPH = new PiernaHabil();
                    oPH.codPierna = Convert.ToInt32(row[0].ToString());
                    oPH.Habilidad = row[1].ToString();

                    lst.Add(oPH);
                }
            }
            return lst;
        }

        public List<TipoCompromisos> GetTiposCompromisos()
        {
            List<TipoCompromisos> lst = new();
            DataTable dt = helper.GetTable("SP_CONSULTAR_TIPOS_COMPROMISOS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TipoCompromisos oTC = new TipoCompromisos();
                    oTC.CodCompromiso = Convert.ToInt32(row[0].ToString());
                    oTC.NombreCompromiso = row[1].ToString();

                    lst.Add(oTC);
                }
            }
            return lst;

        }
        public List<Posicion> GetPosiciones()
        {
            List<Posicion> lst = new();
            DataTable dt = helper.GetTable("SP_CONSULTAR_POSICIONES");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Posicion oPosicion = new Posicion();
                    oPosicion.codPosicion = Convert.ToInt32(row[0].ToString());
                    oPosicion.NombrePosicion = row[1].ToString();

                    lst.Add(oPosicion);
                }
            }
            return lst;

        }

        public List<Compromiso> GetCompromisos()
        {
            List<Compromiso> lst = new();
            List<TipoCompromisos> lstTiposComp = GetTiposCompromisos();

            DataTable dt = helper.GetTable("SP_CONSULTAR_COMPROMISOS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Compromiso oCompromiso = new Compromiso();
                    oCompromiso.CodCompromiso = Convert.ToInt32(row[0].ToString());
                    oCompromiso.CodEquipo = Convert.ToInt32(row[1].ToString());
                    oCompromiso.TipoCompromiso = lstTiposComp.Find(item => item.CodCompromiso == Convert.ToInt32(row[2].ToString()));
                    oCompromiso.ComentariosCompromiso = row[3].ToString();
                    oCompromiso.FechaCompromiso = Convert.ToDateTime(row[4].ToString());
                    oCompromiso.FechaAlta = Convert.ToDateTime(row[5].ToString());
                    if (!row[6].Equals(DBNull.Value))
                        oCompromiso.FechaBaja = Convert.ToDateTime(row[6].ToString());
                    lst.Add(oCompromiso);
                }
            }
            return lst;
        }

        public List<Compromiso> GetProximosCompromisos()
        {
            List<Compromiso> lst = new();
            List<TipoCompromisos> lstTiposComp = GetTiposCompromisos();

            DataTable dt = helper.GetTable("SP_CONSULTAR_COMPROMISOS_FUTUROS_ACTIVOS");
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Compromiso oCompromiso = new Compromiso();
                    oCompromiso.CodCompromiso = Convert.ToInt32(row[0].ToString());
                    oCompromiso.CodEquipo = Convert.ToInt32(row[1].ToString());
                    oCompromiso.TipoCompromiso = lstTiposComp.Find(item => item.CodCompromiso == Convert.ToInt32(row[2].ToString()));
                    oCompromiso.ComentariosCompromiso = row[3].ToString();
                    oCompromiso.FechaCompromiso = Convert.ToDateTime(row[4].ToString());
                    oCompromiso.FechaAlta = Convert.ToDateTime(row[5].ToString());
                    if (!row[6].Equals(DBNull.Value))
                        oCompromiso.FechaBaja = Convert.ToDateTime(row[6].ToString());
                    lst.Add(oCompromiso);
                }
            }
            return lst;

        }


        ////update

        public bool EditEquipo(Equipo oEquipo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oEquipo.CodEquipo);
            parametros.Add("@nombre", oEquipo.Nombre);
            parametros.Add("@loc", oEquipo.CodLocalidad);
            parametros.Add("@fechaAlta", oEquipo.FechaAlta);
            if (!oEquipo.FechaBaja.HasValue)
                parametros.Add("@fechaBaja", DBNull.Value);
            else
                parametros.Add("fechaBaja", oEquipo.FechaBaja);

            return helper.AlterOneElement("SP_EDITAR_EQUIPO", parametros);

        }

        public bool EditPersona(Persona oPersona)
        {
            bool aux;

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oPersona.CodPersona);
            parametros.Add("@nombre", oPersona.Nombre);
            parametros.Add("@apellido", oPersona.Apellido);
            parametros.Add("@cod_tipoDoc", oPersona.TipoDoc);
            parametros.Add("@numeroDocumento", oPersona.NumeroDoc);
            parametros.Add("@fechaNac", oPersona.FechaNac);
            parametros.Add("@piernaHabil", oPersona.PiernaHabil);
            parametros.Add("@peso", oPersona.Peso);
            parametros.Add("@estatura", oPersona.Estatura);
            parametros.Add("@fechaAlta", oPersona.FechaAlta);
            //if (!oPersona.FechaBaja.HasValue)
            //    parametros.Add("@fechaBaja", DBNull.Value);
            //else
            //    parametros.Add("@fechaBaja", oPersona.FechaBaja);

            aux = helper.AlterOneElement("SP_EDITAR_PERSONA", parametros);

            return aux;

        }

        public bool EditPais(Pais oPais)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oPais.IDPais);
            parametros.Add("@nombre", oPais.Nombre);


            return helper.AlterOneElement("SP_EDITAR_PAIS", parametros);

        }


        public bool EditProvincia(Provincia oProvincia)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oProvincia.IDProvincia);
            parametros.Add("@nombre", oProvincia.Nombre);


            return helper.AlterOneElement("SP_EDITAR_PROVINCIA", parametros);

        }


        public bool EditLocalidad(Localidad oLocalidad)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oLocalidad.IDLocalidad);
            parametros.Add("@nombre", oLocalidad.Nombre);


            return helper.AlterOneElement("SP_EDITAR_LOCALIDAD", parametros);

        }


        public bool EditTipoDocumento(TiposDocumentos oTipoDoc)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oTipoDoc.CodTipoDoc);
            parametros.Add("@nombre", oTipoDoc.TipoDoc);


            return helper.AlterOneElement("SP_EDITAR_TIPO_DOCUMENTOS", parametros);

        }


        public bool EditTipoCompromiso(TipoCompromisos oTC)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oTC.CodCompromiso);
            parametros.Add("@nombre", oTC.NombreCompromiso);


            return helper.AlterOneElement("SP_EDITAR_TIPO_COMPROMISO", parametros);

        }

        public bool EditEquipoPersona(EquipoPersona oEP)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@codigo", oEP.CodEP);
            parametros.Add("@cod_persona", oEP.Persona.CodPersona);
            parametros.Add("@cod_equipo", oEP.CodEquipo);
            parametros.Add("@cod_posicion", oEP.CodPosicion);
            parametros.Add("@camiseta", oEP.Camiseta);
            parametros.Add("@fechaAlta", oEP.FechaAlta);
            if(oEP.FechaBaja.HasValue)
                parametros.Add("fechaBaja", oEP.FechaBaja);
            else
                parametros.Add("fechaBaja", DBNull.Value);

            return helper.AlterOneElement("SP_EDITAR_EQUIPO_PERSONA_PORDETALLE", parametros);
        }


        ////delete

        public bool DeletePersona(int idPersona)
        {            
            return helper.DeleteElementsIn3Tables(idPersona, "SP_BAJA_PERSONA", "SP_BAJA_EQUIPO_PERSONA_PORPERSONA");
        }

        public bool DeleteEquipo(int idEquipo)
        {
            return helper.DeleteElementsIn3Tables(idEquipo, "SP_BAJA_EQUIPO", "SP_BAJA_EQUIPO_PERSONA_POREQUIPO", "SP_BAJA_COMPROMISO_POREQUIPO");
        }

        public bool RemoveJugadorDelEquipo(int idJugador)
        {
            return helper.DeleteElement(idJugador, "SP_BAJA_EQUIPO_PERSONA_PORDETALLE");
        }

        public bool DeleteCompromiso(int idCompromiso)
        {
            return helper.DeleteElement(idCompromiso, "SP_BAJA_COMPROMISO");
        }

    }
}
