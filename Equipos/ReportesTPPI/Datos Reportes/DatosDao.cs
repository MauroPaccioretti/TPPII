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
        private static SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True");
        private static SqlCommand cmd;

        
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

        public static DataTable ObtenerHabilidadesPersonas()
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            cmd = new SqlCommand("SP_HABILIDADES_PERSONAS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

    }
}
