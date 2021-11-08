using EquiposBackend.Dominio;
using EquiposFrontend.Cliente;
using EquiposFrontend.Reportes;
using Newtonsoft.Json;
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
            CargarDgvEquiposAsync();

        }

        private async void CargarDgvEquiposAsync()
        {
            string urlEquipos = "https://localhost:44381/api/Equipos/equipos";
            string resultadoEquipos = await ClienteSingleton.GetInstancia().GetAsync(urlEquipos);
            List<Equipo> lstEquipos = JsonConvert.DeserializeObject<List<Equipo>>(resultadoEquipos);

            dgvEquipos.Rows.Clear();
            if (lstEquipos != null)
                foreach (Equipo oEquipo in lstEquipos)
                {
                    dgvEquipos.Rows.Add(new object[] 
                    {
                        oEquipo.CodEquipo,
                        oEquipo.Nombre,
                        oEquipo.Jugadores.Exists(item => item.CodPosicion ==6)?
                            oEquipo.Jugadores.Find(item => item.CodPosicion == 6).Persona.Apellido + ", " + 
                            oEquipo.Jugadores.Find(item => item.CodPosicion == 6).Persona.Nombre : "Sin entrenador",
                        oEquipo.Jugadores == null? "Equipo sin Jugadores": oEquipo.Jugadores.Count(),
                        oEquipo.FechaAlta.ToString("dd/MM/yyyy"),
                        oEquipo.FechaBaja.HasValue? oEquipo.FechaBaja.Value.ToString("dd/MM/yyyy"): "Activo" 
                    });
                }
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
            CargarDgvEquiposAsync();
            
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {


            if (dgvEquipos.SelectedRows.Count == 1)
            {
                int nroEquipo = Convert.ToInt32(dgvEquipos.CurrentRow.Cells["idEquipo"].Value.ToString());
                this.Hide();
                FrmEquipoNuevo frmNvoEquipo = new FrmEquipoNuevo(Accion.Modificar, nroEquipo);
                frmNvoEquipo.ShowDialog();
                this.Show();
                CargarDgvEquiposAsync();

            }

        }

        private void btnBajaEquipo_Click(object sender, EventArgs e)
        {

            if (dgvEquipos.SelectedRows.Count == 1)
            {
                if (dgvEquipos.CurrentRow.Cells["fechaBajaEquipo"].Value.ToString() != "Activo")
                {
                    MessageBox.Show("Equipo ya dado de baja!.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int nroEquipo = Convert.ToInt32(dgvEquipos.CurrentRow.Cells["idEquipo"].Value.ToString());
                this.Hide();
                FrmEquipoNuevo frmNvoEquipo = new FrmEquipoNuevo(Accion.Eliminar, nroEquipo);
                frmNvoEquipo.ShowDialog();
                this.Show();
                CargarDgvEquiposAsync();

            }

            
        }


        

        private void btnNvaPersona_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FrmABM_Persona frmNvaPersona = new FrmABM_Persona(Accion.Agregar);
            frmNvaPersona.ShowDialog();
            this.Show();
        }

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
           // this.Hide();
            FrmListarPersonas frmListarPersonas = new FrmListarPersonas();
            frmListarPersonas.ShowDialog();
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
