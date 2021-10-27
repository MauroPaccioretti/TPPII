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
            cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True;");
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

        public bool addObject(string nomSp, Dictionary<string, object> parameters)
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
    }
}
