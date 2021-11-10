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
        private Usuario oUsuario;
        private List<Equipo> lstEquipos;
        private List<Compromiso> lstCompromisosFuturos;
        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            oUsuario = usuario;
            lblTitulo.Text = "Bienvenido " + usuario.User;
        }

        

        private async void Inicio_Load(object sender, EventArgs e)
        {

            string urlEquipos = "https://localhost:44381/api/Equipos/equipos";
            var resultadoEquipos = await ClienteSingleton.GetInstancia().GetAsync(urlEquipos);
            lstEquipos = JsonConvert.DeserializeObject<List<Equipo>>(resultadoEquipos);

            string urlProximosCompromisos = "https://localhost:44381/api/Equipos/proximosCompromisos";
            var resultadoProximosCompromisos = await ClienteSingleton.GetInstancia().GetAsync(urlProximosCompromisos);
            lstCompromisosFuturos = JsonConvert.DeserializeObject<List<Compromiso>>(resultadoProximosCompromisos);


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
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.paises, Accion.Modificar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.provincias, Accion.Modificar);            
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void cambiarNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.localidades, Accion.Modificar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void cambiarNombreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoDocumentos, Accion.Modificar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void modificarElNombreDeUnTipoDeCompromisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoCompromisos, Accion.Modificar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }


        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.paises, Accion.Agregar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void agregarNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.provincias, Accion.Agregar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void agregarNuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.localidades, Accion.Agregar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void agregarNuevoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoDocumentos, Accion.Agregar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void agregarTipoDeCompromisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoCompromisos, Accion.Agregar);
            frmTablasSoporte.ShowDialog();
            this.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la applicacion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }



        private void tablaDePosicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteTablasPosiciones reporte1 = new ReporteTablasPosiciones();
            reporte1.ShowDialog();
            this.Show();

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la applicacion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private Size? _mouseGrabOffset;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                _mouseGrabOffset = new Size(e.Location);

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _mouseGrabOffset = null;

            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_mouseGrabOffset.HasValue)
            {
                this.Location = Cursor.Position - _mouseGrabOffset.Value;
            }

            base.OnMouseMove(e);
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvCompromisos.Rows)
                {
                    if (dgvCompromisos.CurrentRow.Selected)
                    {
                        int nroEquipo = Convert.ToInt32(dgvEquipos.CurrentRow.Cells["idEquipo"].Value.ToString());
                        List<Compromiso> lstCompromisosActivos = new List<Compromiso>();
                        lstCompromisosActivos.AddRange(lstEquipos.Find(item => item.CodEquipo == nroEquipo).Compromisos);
                        dgvCompromisos.Rows.Clear();

                        if (lstCompromisosActivos.Count != 0)
                            foreach (Compromiso oCompromiso in lstCompromisosActivos)
                            {
                                dgvCompromisos.Rows.Add(new object[] {
                                    oCompromiso.CodEquipo,
                                    oCompromiso.CodCompromiso,
                                    lstEquipos.Find(item => oCompromiso.CodEquipo == item.CodEquipo).Nombre,
                                    oCompromiso.TipoCompromiso.NombreCompromiso,
                                    oCompromiso.FechaCompromiso.ToShortDateString(),
                                    oCompromiso.FechaBaja.Value.ToShortDateString()});
                            }


                    }

                }
                

            }
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                Login login = new Login();
                login.ShowDialog();
            }

        }

        private void informaciónGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoGeneral infoGeneral = new InfoGeneral();
            infoGeneral.ShowDialog();
            this.Show();
        }
    }
}
