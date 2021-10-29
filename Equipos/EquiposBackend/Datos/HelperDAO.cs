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
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                }
                dt.Load(cmd.ExecuteReader());
            }
            catch
            {
                dt = null;
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
                        subject: "Soporte Soccer: Password recovery request",
                        body: "Hi, " + userName + "\n You request to recover your password. \n" +
                        "your current password is : " + accountPass,
                        recipientMail: new List<string> { userMail }
                        );

                    aux = "Hi, " + userName + "\nYou requested to recover your password.\n" +
                        "Please check your email: " + userMail + ", please also check the spam folder.";
                }
                else
                {
                    aux = "Sorry, you do not have an account with that email";
                }
            }
            catch (Exception)
            {
                aux = "Error for send email";
            }
            finally
            {
                CloseConnection(cnn);
            }

            return aux;

        }

    }
}
