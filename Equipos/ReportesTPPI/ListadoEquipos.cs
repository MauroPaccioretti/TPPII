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
            Cargar_COmbo();
        }

        private void Cargar_COmbo()
        {
            DataTable tabla = new DataTable();
            tabla = DatosDao.Cargar_Combo();
            cboEquipos.DataSource = tabla;
            cboEquipos.ValueMember = tabla.Columns[0].ColumnName;
            cboEquipos.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void ListadoEquipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_equiposDataSet1.SP_CONSULTAR_EQUIPOS_LOCALIDAD' Puede moverla o quitarla según sea necesario.
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter.Fill(this.db_equiposDataSet1.SP_CONSULTAR_EQUIPOS_LOCALIDAD);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DatosDao.ObtenerListadoEquipo();

            ReportDataSource ds = new ReportDataSource("DataSetEquiposActivos", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
