using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using ReportesTPPI.Datos_Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesTPPI
{
    public partial class ListadoEquipos : Form
    {
        public ListadoEquipos()
        {
            InitializeComponent();
            //Cargar_COmbo();
            Cargar_DataGrid();
            cboBusqueda_Cargar();
        }

        

        //private void Cargar_COmbo()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = DatosDao.Cargar_Combo();
        //    cboBusqueda.DataSource = tabla;
        //    cboBusqueda.ValueMember = tabla.Columns[0].ColumnName;
        //    cboBusqueda.DisplayMember = tabla.Columns[1].ColumnName;
        //}

        private void ListadoEquipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_equiposDataSet1.SP_CONSULTAR_EQUIPOS_LOCALIDAD' Puede moverla o quitarla según sea necesario.
            //this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter.Fill(this.db_equiposDataSet1.SP_CONSULTAR_EQUIPOS_LOCALIDAD);

            //this.reportViewer1.RefreshReport();
        }

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = DatosDao.ObtenerListadoEquipo();

        //    ReportDataSource ds = new ReportDataSource("DataSetEquiposActivos", tabla);

        //    reportViewer1.LocalReport.DataSources.Clear();
        //    reportViewer1.LocalReport.DataSources.Add(ds);
        //    reportViewer1.LocalReport.Refresh();
        //}

        private void Cargar_DataGrid()
        {
            dgvRespuesta.DataSource = DatosDao.ObtenerListadoEquipo();
            dgvRespuesta.Rows[0].Selected = false;
        }

        private void cboBusqueda_Cargar()
        {
            cboBusqueda.Items.Clear();
            for (int i = 0; i < dgvRespuesta.Columns.Count; i++)
            {
                cboBusqueda.Items.Add(dgvRespuesta.Columns[i].HeaderText);

            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
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

        private void btnBorrar_Click(object sender, EventArgs e)
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
