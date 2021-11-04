using EquiposBackend.Dominio;
using EquiposFrontend.Cliente;
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
    public partial class FrmEquipoNuevo : Form
    {
        Accion modo;
        List<PiernaHabil> lstHabilidad;
        List<Posicion> lstPosi;
        List<Localidad> lstLoc;
        List<TipoCompromisos> lstTC;
        List<Persona> lstPersonas;
        List<Compromiso> lstCompromisos;
        List<Equipo> lstEquipos;
        Equipo oEquipo;
        int idEquipo;
        Compromiso oCompromiso;


        public FrmEquipoNuevo(Accion modo, int idEquipo = 0)
        {
            this.idEquipo = idEquipo;

            this.modo = modo;
            InitializeComponent();
            oEquipo = new Equipo();
            oCompromiso = new Compromiso();

            switch (modo)
            {
                case Accion.Agregar:
                    this.Text = "Agregar nuevo equipo";
                    this.btnConfirmarAccion.Text = "Agregar Equipo";
                    break;
                case Accion.Modificar:
                    this.Text = "Modificar equipo";
                    this.btnConfirmarAccion.Text = "Modificar Equipo";

                    break;
                case Accion.Eliminar:
                    this.Text = "Eliminar equipo";
                    this.btnConfirmarAccion.Text = "Eliminar Equipo";

                    break;
                default:
                    break;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void FrmEquipoNuevo_Load(object sender, EventArgs e)
        {

            string urlEquipos = "https://localhost:44381/api/Equipos/equipos";
            var resultadoEquipos = await ClienteSingleton.GetInstancia().GetAsync(urlEquipos);
            lstEquipos = JsonConvert.DeserializeObject<List<Equipo>>(resultadoEquipos);
            

            string urlCompromisos = "https://localhost:44381/api/Equipos/compromisos";
            var resultadoCompromisos = await ClienteSingleton.GetInstancia().GetAsync(urlCompromisos);
            lstCompromisos = JsonConvert.DeserializeObject<List<Compromiso>>(resultadoCompromisos);
          
            string urlHabilidad = "https://localhost:44381/api/Equipos/piernaHabil";
            var resultadoHabilidad = await ClienteSingleton.GetInstancia().GetAsync(urlHabilidad);
            lstHabilidad = JsonConvert.DeserializeObject<List<PiernaHabil>>(resultadoHabilidad);



            string urlposiciones = "https://localhost:44381/api/Equipos/posiciones";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(urlposiciones);
            List<Posicion> lstPosiciones = JsonConvert.DeserializeObject<List<Posicion>>(resultado);

            lstPosi = lstPosiciones;
            cmbPosiciones.DataSource = lstPosiciones;
            cmbPosiciones.DisplayMember = "NombrePosicion";
            cmbPosiciones.ValueMember = "CodPosicion";
            cmbPosiciones.SelectedIndex = -1;

            string urllocalidades = "https://localhost:44381/api/Equipos/localidades";
            var resultado2 = await ClienteSingleton.GetInstancia().GetAsync(urllocalidades);
            List<Localidad> lstLocalidades = JsonConvert.DeserializeObject<List<Localidad>>(resultado2);
            lstLoc = lstLocalidades;

            //cmbLocalidad.Items.AddRange(lstLocalidades.ToArray());
            cmbLocalidad.DataSource = lstLocalidades;
            cmbLocalidad.DisplayMember = "Nombre";
            cmbLocalidad.ValueMember = "IDLocalidad";
            cmbLocalidad.SelectedIndex = -1;


            string urltipoCompromisos = "https://localhost:44381/api/Equipos/tipoCompromisos";
            string resultado3 = await ClienteSingleton.GetInstancia().GetAsync(urltipoCompromisos);
            List<TipoCompromisos> lstTipoCompromiso = JsonConvert.DeserializeObject<List<TipoCompromisos>>(resultado3);
            lstTC = lstTipoCompromiso;
            cmbTipoCompromiso.DataSource = lstTipoCompromiso;
            cmbTipoCompromiso.DisplayMember = "NombreCompromiso";
            cmbTipoCompromiso.ValueMember = "CodCompromiso";
            cmbTipoCompromiso.SelectedIndex = -1;

            string urlpersonas = "https://localhost:44381/api/Equipos/personas";
            string resultado4 = await ClienteSingleton.GetInstancia().GetAsync(urlpersonas);
            lstPersonas = JsonConvert.DeserializeObject<List<Persona>>(resultado4);



            switch (modo)
            {
                case Accion.Agregar:

                    oEquipo.CodEquipo = lstEquipos == null ? 1 : lstEquipos.Max(t => t.CodEquipo) + 1;
                    if (lstCompromisos.Count() == 0)
                        oCompromiso.CodCompromiso = 1;
                    else
                        oCompromiso.CodCompromiso = lstCompromisos.Max(t => t.CodCompromiso) + 1;
                    CargarDGVPersonasDisponibles();

                    break;
                case Accion.Modificar:
                    CargarEquipo();

                    break;
                case Accion.Eliminar:
                    CargarEquipo();
                    
                    break;
                default:
                    break;


            }

            

        }


        private void CargarEquipo()
        {
            oEquipo = lstEquipos.Find(item => item.CodEquipo == idEquipo);            
            CargarDGVPersonasJugando();
            CargarDGVPersonasDisponibles();
            CargarDGVCompromisos();
            cmbLocalidad.SelectedValue = oEquipo.CodLocalidad;
            txtNombreEquipo.Text = oEquipo.Nombre;

        }

        private void CargarDGVPersonasDisponibles()
        {

            //dgvPersonasDispo.Rows.Clear();

            //if (lstPersonas != null)
            //    foreach (Persona oPersona in lstPersonas)
            //    {

            //        dgvPersonasDispo.Rows.Add(new object[] {

            //        oPersona.CodPersona,
            //        oPersona.Apellido,
            //        oPersona.Nombre,
            //        lstHabilidad.Find(item => oPersona.PiernaHabil == item.codPierna).Habilidad,
            //        oPersona.Peso,
            //        oPersona.Estatura,
            //        oPersona.FechaNac.ToString("dd/MM/yyyy")
            //    });

            //    }
            List<Persona> lstPersonasFiltrada = lstPersonas;
            if (oEquipo.Jugadores.Count() != 0)
            {
                foreach (EquipoPersona oEP in oEquipo.Jugadores)
                {
                    lstPersonasFiltrada.Remove(oEP.Persona);

                }
            }

            dgvPersonasDispo.Rows.Clear();

            if (lstPersonasFiltrada.Count() != 0)
                foreach (Persona oPersona in lstPersonasFiltrada)
                {

                    dgvPersonasDispo.Rows.Add(new object[] {

                    oPersona.CodPersona,
                    oPersona.Apellido,
                    oPersona.Nombre,
                    lstHabilidad.Find(item => oPersona.PiernaHabil == item.codPierna).Habilidad,
                    oPersona.Peso,
                    oPersona.Estatura,
                    oPersona.FechaNac.ToString("dd/MM/yyyy")
                });

                }



        }

        private void CargarDGVPersonasJugando()
        {
            dgvPersonasEquipo.Rows.Clear();
            if (oEquipo.Jugadores != null)
                foreach (EquipoPersona oEP in oEquipo.Jugadores)
                {
                    
                    if (!oEP.FechaAlta.ToString("dd/MM/yyyy").Equals(DateTime.MinValue))
                        oEP.FechaAlta.ToString("dd/MM/yyyy");
                    else
                        oEP.FechaAlta = DateTime.Today;

                    dgvPersonasEquipo.Rows.Add(new object[] {
                    oEP.Persona.CodPersona,
                    oEP.Persona.Apellido,
                    oEP.Persona.Nombre,
                    lstHabilidad.Find(item => oEP.Persona.PiernaHabil == item.codPierna).Habilidad,
                    oEP.Camiseta,
                    oEP.FechaAlta,
                    "Quitar" });
                }
        }

        private void CargarDGVCompromisos()
        {
            dgvCompromisos.Rows.Clear();
            if (oEquipo.Compromisos != null)
                foreach (Compromiso oCompromiso in oEquipo.Compromisos)
                {

                    dgvCompromisos.Rows.Add(new object[] {
                        oCompromiso.CodCompromiso,
                        oEquipo.CodEquipo,
                        lstTC.Find(item => oCompromiso.TipoCompromiso.CodCompromiso == item.CodCompromiso).NombreCompromiso,
                        oCompromiso.ComentariosCompromiso,
                        oCompromiso.FechaCompromiso,
                        "Quitar"});



                }
        }


        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonasDispo.SelectedRows.Count == 1)
            {
                if (ExisteJugadorEnEquipo(Convert.ToInt32(dgvPersonasDispo.CurrentRow.Cells["idPersona"].Value.ToString())))
                {
                    MessageBox.Show("Jugador ya agregado al Equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EquipoPersona oEP = new EquipoPersona();

                oEP.Persona = lstPersonas.Find(item => item.CodPersona == Convert.ToInt32(dgvPersonasDispo.CurrentRow.Cells["idPersona"].Value.ToString()));
                
                if(cmbPosiciones.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione una posición para jugar en el equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                Posicion oPosi = (Posicion)cmbPosiciones.SelectedItem;
                oEP.CodPosicion = oPosi.codPosicion;

                if (txtCamiseta.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Por favor ingrese datos de la camiseta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                oEP.Camiseta = txtCamiseta.Text;

                oEquipo.AgregarJugador(oEP);

                CargarDGVPersonasJugando();
                CargarDGVPersonasDisponibles();
            }
                
        }



        private bool ExisteJugadorEnEquipo(int idJugador)
        {
            foreach (DataGridViewRow fila in dgvPersonasEquipo.Rows)
            {
                if (fila.Cells["idJugador"].Value.Equals(idJugador))
                    return true;
            }
            return false;
        }

        private void btnAgregarCompromiso_Click(object sender, EventArgs e)
        {
            if (txtCompromiso.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor ingrese detalles del compromiso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(dtpCompromiso.Value.Date == DateTime.Today)
            {
                if (MessageBox.Show("Esta seguro que desea agregar un compromiso hoy?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

            }

            if(cmbTipoCompromiso.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija un tipo de compromiso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oCompromiso.CodCompromiso++;
            oCompromiso.CodEquipo = oEquipo.CodEquipo;
            oCompromiso.ComentariosCompromiso = txtCompromiso.Text;
            oCompromiso.FechaCompromiso = dtpCompromiso.Value;
            TipoCompromisos oTC = new TipoCompromisos();
            oTC = (TipoCompromisos)cmbTipoCompromiso.SelectedItem;
            oCompromiso.TipoCompromiso = oTC;
            oEquipo.AgregarCompromiso(oCompromiso);
            CargarDGVCompromisos();
        }

        private async void btnConfirmarAccion_Click(object sender, EventArgs e)
        {
            if (txtNombreEquipo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor elija un nombre para su equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(dgvPersonasEquipo.Rows.Count == 0)
            {
                if (MessageBox.Show("Esta seguro que desea crear un equipo sin jugadores?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            if(dgvCompromisos.Rows.Count == 0)
            {
                if (MessageBox.Show("Esta seguro que desea crear un equipo sin compromisos?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            if(cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija una localidad para su equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string datosJSON = JsonConvert.SerializeObject(oEquipo);
            switch (modo)
            {
                case Accion.Agregar:
                    try
                    {
                        string url = "https://localhost:44381/api/Equipos/crearEquipoFull";
                        string resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);
                        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Error al Registrar", "Resultado", MessageBoxButtons.OK);
                        return;
                    }
                    break;
                case Accion.Modificar:


                    break;
                case Accion.Eliminar:


                    break;
            }

        }

        private void dgvPersonasEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonasEquipo.CurrentCell.ColumnIndex == 6)
            {
                oEquipo.QuitarJugador(Convert.ToInt32(dgvPersonasEquipo.CurrentRow.Cells["idJugador"].Value.ToString()));
                dgvPersonasEquipo.Rows.Remove(dgvPersonasEquipo.CurrentRow);
            }
        }

        private void dgvCompromisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompromisos.CurrentCell.ColumnIndex == 5)
            {
                oEquipo.QuitarCompromiso(Convert.ToInt32(dgvCompromisos.CurrentRow.Cells["idCompromiso"].Value.ToString()));
                dgvCompromisos.Rows.Remove(dgvCompromisos.CurrentRow);
            }
        }
    }
}

