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
    public partial class FrmListarPersonas : Form
    {

        List<PiernaHabil> lstHabilidad = new();
        List<TiposDocumentos> lstTipoDocs = new List<TiposDocumentos>();
        public FrmListarPersonas()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNvoEquipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmABM_Persona frmNvaPersona = new FrmABM_Persona(Accion.Agregar);
            frmNvaPersona.ShowDialog();
            
        }

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count == 1)
            {
                int nroPersona = Convert.ToInt32(dgvPersonas.CurrentRow.Cells["idPersona"].Value.ToString());
                FrmABM_Persona frmPersonaABM = new FrmABM_Persona(Accion.Modificar, nroPersona);
                frmPersonaABM.ShowDialog();
            }

        }

        private void btnBajaPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count == 1)
            {
                int nroPersona = Convert.ToInt32(dgvPersonas.CurrentRow.Cells["idPersona"].Value.ToString());
                FrmABM_Persona frmPersonaABM = new FrmABM_Persona(Accion.Eliminar, nroPersona);
                frmPersonaABM.ShowDialog();
            }

        }

        private void btnRegistrarNuevaPersona_Click(object sender, EventArgs e)
        {

            FrmABM_Persona frmPersonaABM = new FrmABM_Persona(Accion.Agregar);
            frmPersonaABM.ShowDialog();

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> filtros = new Dictionary<string, object>();
            int nroDoc;
            int estaturaDesde;
            int estaturaHasta;
            double pesoDesde;
            double pesoHasta;


            if (!txtNroDoc.Text.Equals(""))
                try
                {
                    nroDoc = Convert.ToInt32(txtNroDoc.Text);
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese un Documento Numérico.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNroDoc.Focus();
                    return;
                }


            if (!txtEstaturaDesde.Text.Equals(""))
                try
                {
                    estaturaDesde = Convert.ToInt32(txtEstaturaDesde.Text);
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese una estatura numérica.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEstaturaDesde.Focus();
                    return;
                }
            if (!txtEstaturaHasta.Text.Equals(""))
                try
                {
                    estaturaHasta = Convert.ToInt32(txtEstaturaHasta.Text);
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese una estatura numérica.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEstaturaHasta.Focus();
                    return;
                }
            if (!txtPesoDesde.Text.Equals(""))
                try
                {
                    pesoDesde = Convert.ToDouble(txtPesoDesde.Text);
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese un peso numérico.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPesoDesde.Focus();
                    return;
                }
            if (!txtPesoHasta.Text.Equals(""))
                try
                {
                    pesoHasta = Convert.ToDouble(txtPesoHasta.Text);
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese un peso numérico.", "Verificacion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPesoHasta.Focus();
                    return;
                }

            filtros.Add("@nombre", txtNombre.Text.Equals("") ? DBNull.Value : txtNombre.Text);
            filtros.Add("@apellido", txtApellido.Text.Equals("") ? DBNull.Value : txtApellido.Text);
            filtros.Add("@fechaDesde", dtpFechaNacimientoDesde.Value.ToShortDateString());
            filtros.Add("@fechaHasta", dtpFechaNacimientoHasta.Value.ToShortDateString());
            filtros.Add("@tipoDoc", chbTipoDoc.Checked ? cmbTipoDni.SelectedValue : DBNull.Value);
            filtros.Add("@estaturaDesde", txtEstaturaDesde.Text.Equals("") ? DBNull.Value : txtEstaturaDesde.Text);
            filtros.Add("@estaturaHasta", txtEstaturaHasta.Text.Equals("") ? DBNull.Value : txtEstaturaHasta.Text);
            filtros.Add("@pesoDesde", txtPesoDesde.Text.Equals("") ? DBNull.Value : txtPesoDesde.Text);
            filtros.Add("@pesoHasta", txtPesoHasta.Text.Equals("") ? DBNull.Value : txtPesoHasta.Text);
            filtros.Add("@tipoPierna", chbPierna.Checked ? cmbPierna.SelectedValue : DBNull.Value);
            filtros.Add("@baja", chbBaja.Checked ? 1 : 0);

            Dictionary<string, object> filtrosSinNull = new Dictionary<string, object>();
            foreach(KeyValuePair<string,object> item in filtros)
            {
                if(item.Value != DBNull.Value)
                {
                    filtrosSinNull.Add(item.Key,item.Value);
                }
            }

            string datosJSON = JsonConvert.SerializeObject(filtrosSinNull);
            string url = "https://localhost:44381/api/Equipos/consultarPersonasConFiltro";
            string resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);
            List<Persona> lst = JsonConvert.DeserializeObject<List<Persona>>(resultado);


            dgvPersonas.Rows.Clear();
            foreach (Persona oPersona in lst)
            {
                dgvPersonas.Rows.Add(new object[] {
                    oPersona.CodPersona,                    
                    oPersona.Apellido,
                    oPersona.Nombre,
                    lstTipoDocs.Find(item => oPersona.TipoDoc == item.CodTipoDoc).TipoDoc,
                    oPersona.NumeroDoc,
                    oPersona.FechaNac.ToString("dd/MM/yyyy"),
                    lstHabilidad.Find(item => oPersona.PiernaHabil == item.codPierna).Habilidad,
                    oPersona.Peso,
                    oPersona.Estatura,
                    oPersona.FechaAlta.ToString("dd/MM/yyyy"),
                    oPersona.FechaBaja.HasValue ? oPersona.FechaBaja.Value.ToString("dd/MM/yyyy") : "Activo"

                });
            }
        }

        private async void FrmListarPersonas_Load(object sender, EventArgs e)
        {
            string url = "https://localhost:44381/api/Equipos/tipoDocumentos";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<TiposDocumentos> lstTipoDNI = JsonConvert.DeserializeObject<List<TiposDocumentos>>(resultado);
            lstTipoDocs = lstTipoDNI;
            cmbTipoDni.DataSource = lstTipoDNI;
            cmbTipoDni.DisplayMember = "TipoDoc";
            cmbTipoDni.ValueMember = "CodTipoDoc";

            string url2 = "https://localhost:44381/api/Equipos/piernaHabil";
            var resultado2 = await ClienteSingleton.GetInstancia().GetAsync(url2);
            List<PiernaHabil> lstPiernas = JsonConvert.DeserializeObject<List<PiernaHabil>>(resultado2);
            lstHabilidad = lstPiernas;
            cmbPierna.DataSource = lstPiernas;
            cmbPierna.DisplayMember = "Habilidad";
            cmbPierna.ValueMember = "CodPierna";
        }


=======
        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }
>>>>>>> 32d0c3ddea2ad565df79d1fc5868c47ecbd40f56
    }
}
