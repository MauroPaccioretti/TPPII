using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBackend.Datos
{
    public class HelperDAO
    {
        private static HelperDAO instance;
        private SqlConnection cnn;

        
        private HelperDAO()
        {
            cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True");
            
        }


        public static HelperDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDAO();
            }
            return instance;
        }

        public void CloseConnection(SqlConnection cnn)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public bool addObject(string nomSp, Dictionary<string, object> parameters = null)
        {
            bool aux = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(nomSp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                if(parameters != null)
                {
                    foreach (KeyValuePair<string, object> p in parameters)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                }

                aux = cmd.ExecuteNonQuery()==1;                
                return aux;

            }

            catch (SqlException)
            {
                return aux;
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        public DataTable GetTable(string sp, Dictionary<string, object> parameters = null) 
        {
            DataTable dt = new DataTable();

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null) 
                {
                    foreach (KeyValuePair<string, object> p in parameters)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value.ToString());
                    }
                }
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                dt = null;
                string mensaje = ex.Message;
            }
            finally
            {
                CloseConnection(cnn); 
            }

            return dt;
        }

        public bool DeleteElement(int idElemento, string spCommand)
        {
            bool aux = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(spCommand, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", idElemento);
                cmd.ExecuteNonQuery();
                aux = true;
            }
            catch
            {
                aux = false;
            }
            finally
            {
                CloseConnection(cnn);
            }

            return aux;
        }

        public bool CrearEquipo(Equipo oEquipo)
        {
            bool aux = false;
            SqlTransaction t =null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_EQUIPO", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oEquipo.Nombre);
                cmd.Parameters.AddWithValue("@localidad", oEquipo.CodLocalidad);
                cmd.ExecuteNonQuery();
                
                if(oEquipo.Jugadores != null)
                    foreach(EquipoPersona oEP in oEquipo.Jugadores)
                    {
                        SqlCommand cmd2 = new SqlCommand("SP_INSERTAR_EQUIPOS_PERSONAS", cnn, t);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@cod_persona", oEP.Persona.CodPersona);
                        cmd2.Parameters.AddWithValue("@cod_equipo", oEquipo.CodEquipo);
                        cmd2.Parameters.AddWithValue("@cod_posicion", oEP.CodPosicion);
                        cmd2.Parameters.AddWithValue("@camiseta", oEP.Camiseta);
                        cmd2.ExecuteNonQuery();
                    }

                if(oEquipo.Compromisos != null)
                    foreach(Compromiso comp in oEquipo.Compromisos)
                    {
                        SqlCommand cmd3 = new SqlCommand("SP_INSERTAR_COMPROMISO", cnn, t);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.AddWithValue("@cod_equipo", oEquipo.CodEquipo);
                        cmd3.Parameters.AddWithValue("@cod_tipoCompromiso", comp.TipoCompromiso.CodCompromiso);
                        cmd3.Parameters.AddWithValue("@comentariosCompromiso", comp.ComentariosCompromiso);
                        cmd3.Parameters.AddWithValue("@fechaCompromiso", comp.FechaCompromiso);
                        cmd3.ExecuteNonQuery();

                    }
                aux = true;
                t.Commit();
            }
            catch
            {
                aux = false;
                t.Rollback();
            }
            finally
            {
                CloseConnection(cnn);
            }




            return aux;
        }


        public bool DeleteElementsIn3Tables(int idElemento, string spCommand1, string spCommand2, string spCommand3 = "")
        {
            bool aux = false;
            SqlTransaction t = null;
            try
            {
                
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd1 = new SqlCommand(spCommand1, cnn, t);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@codigo", idElemento);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand(spCommand2, cnn, t);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@codigo", idElemento);
                cmd2.ExecuteNonQuery();
                

                if (!spCommand3.Equals(""))
                {
                    SqlCommand cmd3 = new SqlCommand(spCommand3, cnn, t);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("@codigo", idElemento);
                    cmd3.ExecuteNonQuery();
                    
                }

                t.Commit();
                aux = true;
            }
            catch
            {
                aux = false;
                t.Rollback();
            }
            finally
            {
                CloseConnection(cnn);
            }

            return aux;
        }


        public bool Login(string user, string pass)
        {
            bool aux = false;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "SP_CONSULTAR_USUARIOS_LOGIN";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return aux = true;
                }
                else
                {
                    return aux = false;
                }
            }
            catch (Exception)
            {
                aux = false;
            }
            finally
            {
                CloseConnection(cnn);
            }
            return aux;

        }


        public string RecoverPassword(string userRequesting)
        {
            string aux = "";
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "SP_RECOVERY_PASSWORD";
                cmd.Parameters.AddWithValue("@email", userRequesting);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    string userName = reader.GetString(1);
                    string userMail = reader.GetString(4);
                    string accountPass = reader.GetString(2);
                    var mailService = new MailServices.SystemSupportEmail();
                    mailService.SendEmail(
                        subject: "Soporte Soccer: Solicitud de recupero de contraseña",
                        body: "Hola, " + userName + "\nUsted solicito recuperar su contraseña. \n" +
                        "Su contraseña actual es: " + accountPass,
                        recipientMail: new List<string> { userMail }
                        );

                    aux = "Hola, " + userName + "\nUsted solicito recuperar su contraseña.\n" +
                        "Por favor verifique en su email: " + userMail + ",\nporfavor tambien verifique en la casilla Spam.";
                }
                else
                {
                    aux = "Usted no tiene una cuenta asociada con ese email";
                }
            }
            catch (Exception)
            {
                aux = "Error al enviar";
            }
            finally
            {
                CloseConnection(cnn);
            }

            return aux;
        }


        public bool UpdateElement(string spCommand, Dictionary<string, object> parametros = null)
        {
            bool aux = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(spCommand, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    foreach (KeyValuePair<string, object> p in parametros)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value.ToString());
                    }
                cmd.ExecuteNonQuery();

                aux = true;
            }
            catch
            {
                aux = false;
            }
            finally
            {
                CloseConnection(cnn);
            }
            return aux;


        }


        public bool AlterOneElement( string spCommand, Dictionary<string , object> parametros = null )
        {
            SqlTransaction t = null;
            bool aux;
            try
            {
                
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(spCommand, cnn, t);                
                cmd.CommandType = CommandType.StoredProcedure;
                if(parametros != null)
                    foreach(KeyValuePair<string, object> p in parametros)
                    {
                        if (p.Value == null || p.Value.ToString() == "")
                            cmd.Parameters.AddWithValue(p.Key, DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                {
                    t.Commit();
                    aux = true;
                }
                else
                {
                    t.Rollback();
                    aux = false;
                }
                
            }
            catch (Exception ex)
            {
                string m = ex.Message;
                t.Rollback();
                aux = false;

            }
            finally
            {
                CloseConnection(cnn);
            }

            return aux;

        }

    }
}
