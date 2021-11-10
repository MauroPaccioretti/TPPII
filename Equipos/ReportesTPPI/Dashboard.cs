using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportesTPPI.Datos_Reportes;
using System.Data.SqlClient;

namespace ReportesTPPI
{
    public partial class Dashboard : Form
    {

        private static SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_equipos;Integrated Security=True");
        private static SqlCommand cmd;

        ArrayList Habilidad = new ArrayList();
        ArrayList Cantidad = new ArrayList();

        public Dashboard()
        {
            InitializeComponent();
            DashboardDatos();
            Cargar_DataGrid();
            cboBusqueda_Cargar();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GetHabilidades();
        }


        private void GetHabilidades()
        {
            cnn.Open();
            cmd = new SqlCommand("SP_HABILIDADES_PERSONAS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Habilidad.Add(dr.GetString(0));
                Cantidad.Add(dr.GetInt32(1));
            }
            chtHabilidades.Series[0].Points.DataBindXY(Habilidad, Cantidad);
            dr.Close();
            cnn.Close();

        }

        private void DashboardDatos()
        {
            cnn.Open();
            cmd = new SqlCommand("SP_DASHBOARD", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter resEquipos = new SqlParameter("@resEquipos", 0); resEquipos.Direction = ParameterDirection.Output;
            SqlParameter resEquiposAct = new SqlParameter("@resEquiposAct", 0);  resEquiposAct.Direction = ParameterDirection.Output;
            SqlParameter resJugadores = new SqlParameter("@resJugadores", 0); resJugadores.Direction = ParameterDirection.Output;
            SqlParameter resJugadoresAct = new SqlParameter("@resJugadoresAct", 0); resJugadoresAct.Direction = ParameterDirection.Output;
            SqlParameter resComprom  = new SqlParameter("@resComprom", 0); resComprom.Direction = ParameterDirection.Output;
            SqlParameter resCompromAct = new SqlParameter("@resCompromAct", 0); resCompromAct.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(resEquipos);
            cmd.Parameters.Add(resEquiposAct);
            cmd.Parameters.Add(resJugadores);
            cmd.Parameters.Add(resJugadoresAct);
            cmd.Parameters.Add(resComprom);
            cmd.Parameters.Add(resCompromAct);

            cmd.ExecuteNonQuery();
            lbl_CantEquipos.Text = cmd.Parameters["@resEquipos"].Value.ToString();
             lbl_CantEqAct.Text = cmd.Parameters["@resEquiposAct"].Value.ToString();
             lbl_CantJug.Text = cmd.Parameters["@resJugadores"].Value.ToString();
             lbl_CantJugAct.Text = cmd.Parameters["@resJugadoresAct"].Value.ToString();
             lbl_CantComp.Text = cmd.Parameters["@resComprom"].Value.ToString();
             lbl_CantCompAct.Text = cmd.Parameters["@resCompromAct"].Value.ToString();
            cnn.Close();

        }

        private void Cargar_DataGrid()
        {
            dgvRespuesta.DataSource = DatosDao.ObtenerListadoEquipo();
            dgvRespuesta.Rows[0].Selected = false;
            dgvRespuesta.Columns[0].Selected = false;
        }

        private void cboBusqueda_Cargar()
        {
            cboBusqueda.Items.Clear();
            for (int i = 0; i < dgvRespuesta.Columns.Count; i++)
            {
                cboBusqueda.Items.Add(dgvRespuesta.Columns[i].HeaderText);

            }
        }

        //private void btnFiltro_Click(object sender, EventArgs e)
        //{
        //    if (cboBusqueda.SelectedItem == null)
        //    {
        //        MessageBox.Show("Debe seleccionar la columna por la cual quiere filtrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }

        //    else if (txtFiltro.Text == "")
        //    {
        //        MessageBox.Show("Debe ingresar un campo por el cual filtrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        txtFiltro.Focus();
        //    }
        //    else
        //    {

        //        foreach (DataGridViewRow Row in dgvRespuesta.Rows)
        //        {
        //            String strFila = Row.Index.ToString();
        //            string valor = Convert.ToString(Row.Cells[cboBusqueda.SelectedIndex].Value);

        //            if (valor == this.txtFiltro.Text)
        //            {
        //                dgvRespuesta.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.OrangeRed;
        //            }
        //        }
        //    }
        //}

        //private void btnBorrar_Click(object sender, EventArgs e)
        //{
        //    cboBusqueda.Text = "";
        //    txtFiltro.Text = "";
        //    foreach (DataGridViewRow Row in dgvRespuesta.Rows)
        //    {
        //        String strFila = Row.Index.ToString();
        //        dgvRespuesta.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
        //    }
        //}

        private void btnFiltro_Click_1(object sender, EventArgs e)
        {
            if (cboBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar la columna por la cual quiere filtrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtFiltro.Text == "")
            {
                MessageBox.Show("Debe ingresar un campo por el cual filtrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFiltro.Focus();
            }
            else
            {

                foreach (DataGridViewRow Row in dgvRespuesta.Rows)
                {
                    String strFila = Row.Index.ToString();
                    string valor = Convert.ToString(Row.Cells[cboBusqueda.SelectedIndex].Value);

                    if (valor == this.txtFiltro.Text)
                    {
                        dgvRespuesta.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                }
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            cboBusqueda.Text = "";
            txtFiltro.Text = "";
            foreach (DataGridViewRow Row in dgvRespuesta.Rows)
            {
                String strFila = Row.Index.ToString();
                dgvRespuesta.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }


}

