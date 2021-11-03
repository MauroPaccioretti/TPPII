using EquiposBackend.Dominio;
using EquiposFrontend.Reportes;
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
            lblTitulo.Text = "Bienvenido " + usuario.User;
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



        private void tablaDePosicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteTablasPosiciones reporte1 = new ReporteTablasPosiciones();
            reporte1.ShowDialog();
            

        }




        private void btnNvoEquipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEquipoNuevo frmNvoEquipo = new FrmEquipoNuevo(Accion.Agregar);
            frmNvoEquipo.ShowDialog();
            this.Show();
            
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEquipoNuevo frmNvoEquipo = new FrmEquipoNuevo(Accion.Modificar);
            frmNvoEquipo.ShowDialog();
            this.Show();
        }

        private void btnBajaEquipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEquipoNuevo frmNvoEquipo = new FrmEquipoNuevo(Accion.Eliminar);
            frmNvoEquipo.ShowDialog();
            this.Show();
        }


        

        private void btnNvaPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmABM_Persona frmNvaPersona = new FrmABM_Persona(Accion.Agregar);
            frmNvaPersona.ShowDialog();
            this.Show();
        }

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListarPersonas frmListarPersonas = new FrmListarPersonas();
            frmListarPersonas.ShowDialog();
            this.Show();
        }

        private void btnBajaPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListarPersonas frmListarPersonas = new FrmListarPersonas();
            frmListarPersonas.ShowDialog();

            this.Show();
        }
    }
}
