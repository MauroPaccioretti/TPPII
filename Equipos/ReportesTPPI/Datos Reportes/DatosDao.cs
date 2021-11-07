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
<<<<<<< HEAD
        private static SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True");
=======
        //Cambiar cadena para quien presente.
        //private static SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-I4SKB1G\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True");
        private static SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-59VKSU4\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True");

>>>>>>> b26a4661f732f369c9f7c82e5fc406f14e00dc23
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
