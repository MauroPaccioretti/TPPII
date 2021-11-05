using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ReportesTPPI.Datos_Reportes
{
    class DatosDao
    {
        private static SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-I4SKB1G\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True");
        private static SqlCommand cmd;

        public static DataTable Cargar_Combo()
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            cmd = new SqlCommand("SP_CONSULTAR_EQUIPOS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
            
        }
        public static DataTable ObtenerListadoEquipo()
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            cmd = new SqlCommand("SP_CONSULTAR_EQUIPOS_LOCALIDAD", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

    }
}
