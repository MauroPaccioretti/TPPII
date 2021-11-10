using EquiposBackend.Dominio;
using EquiposFrontend.Cliente;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
    public partial class FrmABM_Persona : Form
    {
        Persona oPersona;
        Accion modo;
        int idPersona;
        public FrmABM_Persona(Accion modo, int IdPersona = 0)
        {
            InitializeComponent();
            this.modo = modo;
            this.idPersona = IdPersona;
            oPersona = new Persona();
            switch (modo)
            {
                case Accion.Agregar:
                    oPersona = new Persona();
                    lblTitulo.Text = "Registrar Persona";
                    btnConfirmarAccion.Text = "Registrar Persona";
                    break;
                case Accion.Modificar:
                    lblTitulo.Text = "Editar datos de una Persona";
                    btnConfirmarAccion.Text = "Editar Persona";
                    break;
                case Accion.Eliminar:
                    lblTitulo.Text = "Dar de baja a una Persona";
                    btnConfirmarAccion.Text = "Dar de baja a la Persona";
                    break;
                default:
                    break;
            }


        }

        private async void FrmABM_Persona_Load(object sender, EventArgs e)
        {

            string url = "https://localhost:44381/api/Equipos/tipoDocumentos";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<TiposDocumentos> lstTipoDNI = JsonConvert.DeserializeObject<List<TiposDocumentos>>(resultado);
            cmbTipoDni.DataSource = lstTipoDNI;
            cmbTipoDni.DisplayMember = "TipoDoc";
            cmbTipoDni.ValueMember = "CodTipoDoc";
            cmbTipoDni.SelectedIndex = -1;

            string url2 = "https://localhost:44381/api/Equipos/piernaHabil";
            var resultado2 = await ClienteSingleton.GetInstancia().GetAsync(url2);
            List<PiernaHabil> lstPiernas = JsonConvert.DeserializeObject<List<PiernaHabil>>(resultado2);
            cmbPierna.DataSource = lstPiernas;
            cmbPierna.DisplayMember = "Habilidad";
            cmbPierna.ValueMember = "CodPierna";
            cmbPierna.SelectedIndex = -1;

            switch (modo)
            {
                case Accion.Agregar:
                    dtpFechaNacimiento.Value = DateTime.Today;

                    break;
                case Accion.Modificar:
                    CargarPersona(idPersona);

                    break;
                case Accion.Eliminar:
                    CargarPersona(idPersona);
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtEstatura.Enabled = false;
                    txtNroDoc.Enabled = false;
                    txtPeso.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    cmbPierna.Enabled = false;
                    cmbTipoDni.Enabled = false;
                    btnAgregarTipoDni.Enabled = false;

                    break;
                default:
                    break;
            }

        }

        private async void CargarPersona(int idPersona)
        {
            string url = "https://localhost:44381/api/Equipos/personas";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<Persona> lst = JsonConvert.DeserializeObject<List<Persona>>(resultado);
            oPersona = lst.Find(item => item.CodPersona == idPersona);

            txtNombre.Text = oPersona.Nombre;
            txtApellido.Text = oPersona.Apellido;
            dtpFechaNacimiento.Value = oPersona.FechaNac;
            cmbTipoDni.SelectedValue = oPersona.TipoDoc;
            txtNroDoc.Text = oPersona.NumeroDoc.ToString();
            txtEstatura.Text = oPersona.Estatura.ToString();
            txtPeso.Text = oPersona.Peso.ToString();
            cmbPierna.SelectedValue = oPersona.PiernaHabil;

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEstatura.Text = "";
            txtNroDoc.Text = "";
            txtPeso.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbPierna.SelectedIndex = -1;
            cmbTipoDni.SelectedIndex = -1;
           
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnConfirmarAccion_Click(object sender, EventArgs e)
        {
            

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor ingrese un Nombre.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;

            }

            if (txtApellido.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor ingrese un Apellido.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return;

            }

            if (cmbTipoDni.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor ingrese un Tipo de Documento.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoDni.Focus();
                return;
            }

            if (txtNroDoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor ingrese un número de Documento.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroDoc.Focus();
                return;
            }

            try
            {
                oPersona.NumeroDoc = Convert.ToInt32(txtNroDoc.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un Documento Numérico.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroDoc.Focus();
                return;
            }


            if (txtEstatura.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor ingrese una estatura.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstatura.Focus();
                return;
            }

            try
            {
                oPersona.Estatura = Convert.ToDouble(txtEstatura.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese una estatura numérica.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstatura.Focus();
                return;
            }

            if (txtPeso.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor ingrese un peso.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            try
            {
                oPersona.Peso = Convert.ToDouble(txtPeso.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese una peso numérico.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            if (cmbPierna.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor ingrese una Pierna Hábil.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPierna.Focus();
                return;
            }

            if (oPersona.Estatura > 350 || oPersona.Estatura < 30)
            {
                MessageBox.Show("Por favor verifique que la estatura sea en centímetros.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstatura.Focus();
                return;
            }

            if (oPersona.Peso > 10 || oPersona.Peso < 330)
            {
                MessageBox.Show("Por favor verifique que el peso sea correcto (separador decimal es coma).", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstatura.Focus();
                return;
            }


            if (dtpFechaNacimiento.Value.Equals(DateTime.Today))
            {
                MessageBox.Show("Por favor ingrese una fecha de nacimiento válida.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return;
            }

            oPersona.Nombre = txtNombre.Text;
            oPersona.Apellido = txtApellido.Text;
            TiposDocumentos oTC = (TiposDocumentos)cmbTipoDni.SelectedItem;
            oPersona.TipoDoc = oTC.CodTipoDoc;
            PiernaHabil oPH = (PiernaHabil)cmbPierna.SelectedItem;
            oPersona.PiernaHabil = oPH.codPierna;
            oPersona.FechaNac = dtpFechaNacimiento.Value;

            string datosJSON = JsonConvert.SerializeObject(oPersona);

            /*
            string datos1JSON = JsonConvert.SerializeObject(oPersona , 
                new IsoDateTimeConverter() {DateTimeFormat = "dd-MM-yyyy" });

            string datos2Json = JsonConvert.SerializeObject(oPersona, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            JsonSerializer jsonWriter = new JsonSerializer { NullValueHandling = NullValueHandling.Ignore };
            var formatting = new JsonSerializerSettings { DateFormatString = "dd-MM-yyyy", NullValueHandling = NullValueHandling.Ignore};
            string datos3Json = JsonConvert.SerializeObject(oPersona, formatting);
            */
            switch (modo)
            {
                case Accion.Agregar:
                    try
                    {

                        string url = "https://localhost:44381/api/Equipos/insertarPersona";
                        string resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);
                        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);
                        LimpiarCampos();
                        oPersona = new Persona();
                    }
                    catch
                    {
                        MessageBox.Show("Error al Registrar", "Resultado", MessageBoxButtons.OK);
                        return;
                    }

                    break;
                case Accion.Modificar:
                    try
                    {

                        string url = "https://localhost:44381/api/Equipos/editarPersona";
                        string resultado = await ClienteSingleton.GetInstancia().PutAsync(url, datosJSON);
                        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);                        
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error al Editar", "Resultado", MessageBoxButtons.OK);
                        return;
                    }


                    break;
                case Accion.Eliminar:

                    if (MessageBox.Show("Esta seguro que desea dar de baja a la persona?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {

                            string url = "https://localhost:44381/api/Equipos/persona/" + oPersona.CodPersona;
                            string resultado = await ClienteSingleton.GetInstancia().DeleteAsync(url);
                            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);
                        }
                        catch
                        {
                            MessageBox.Show("Error al dar de baja", "Resultado", MessageBoxButtons.OK);
                            return;
                        }
                        this.Close();
                    }

                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void btnAgregarTipoDni_Click_1(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoDocumentos, Accion.Agregar);
            this.Opacity = 0.3;
            frmTablasSoporte.ShowDialog();
            
            this.Opacity = 1;
            string url = "https://localhost:44381/api/Equipos/tipoDocumentos";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<TiposDocumentos> lstTipoDNI = JsonConvert.DeserializeObject<List<TiposDocumentos>>(resultado);
            cmbTipoDni.DataSource = lstTipoDNI;
            cmbTipoDni.DisplayMember = "TipoDoc";
            cmbTipoDni.ValueMember = "CodTipoDoc";
            cmbTipoDni.SelectedIndex = -1;


        }

        // para mover el form manteniendo click derecho
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





    }
}