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
    public partial class CantidadXHabilidad : Form
    {
        public CantidadXHabilidad()
        {
            InitializeComponent();
        }

        private void CantidadXHabilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_equiposDataSet.SP_CONSULTAR_EQUIPOS_LOCALIDAD' Puede moverla o quitarla según sea necesario.
            this.SP_CONSULTAR_EQUIPOS_LOCALIDADTableAdapter.Fill(this.db_equiposDataSet.SP_CONSULTAR_EQUIPOS_LOCALIDAD);
            // TODO: esta línea de código carga datos en la tabla 'db_equiposDataSet.SP_HABILIDADES_PERSONAS' Puede moverla o quitarla según sea necesario.
            this.SP_HABILIDADES_PERSONASTableAdapter.Fill(this.db_equiposDataSet.SP_HABILIDADES_PERSONAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
