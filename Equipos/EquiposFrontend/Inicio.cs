using EquiposBackend.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquiposFrontend
{
    public partial class Inicio : Form
    {
        Usuario oUsuario;
        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            oUsuario = usuario; 
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
                        
        }

        private void Principal_FormClosing(object sender, EventArgs e)
        {
            //MessageBox.Show("Thank you for using this service.", "Goodbye.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void editarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.paises, Accion.Modificar);
            frmTablasSoporte.Show();
        }

        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.provincias, Accion.Modificar);
            frmTablasSoporte.Show();
        }

        private void cambiarNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.localidades, Accion.Modificar);
            frmTablasSoporte.Show();
        }

        private void cambiarNombreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoDocumentos, Accion.Modificar);
            frmTablasSoporte.Show();
        }

        private void modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoCompromisos, Accion.Modificar);
            frmTablasSoporte.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Log Out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.paises, Accion.Agregar);
            frmTablasSoporte.Show();
        }

        private void agregarNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.provincias, Accion.Agregar);
            frmTablasSoporte.Show();
        }

        private void agregarNuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.localidades, Accion.Agregar);
            frmTablasSoporte.Show();
        }

        private void agregarNuevoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoDocumentos, Accion.Agregar);
            frmTablasSoporte.Show();
        }

        private void agregarTipoDeCompromisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoCompromisos, Accion.Agregar);
            frmTablasSoporte.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}
