using Microsoft.Reporting.WinForms;
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
    public partial class GráficoXX : Form
    {
        public GráficoXX()
        {
            InitializeComponent();
        }

        private void GráficoXX_Load(object sender, EventArgs e)
        { 
            dataGridView1.DataSource = DatosDao.ObtenerHabilidadesPersonas();
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = DatosDao.ObtenerHabilidadesPersonas();

            ReportDataSource ds = new ReportDataSource("DataSetEQUIPOS", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();
        }
    }
}
