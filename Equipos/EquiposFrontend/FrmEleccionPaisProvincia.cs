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
    public partial class FrmEleccionPaisProvincia : Form
    {
        public int IdProvincia { get; set; }

        public FrmEleccionPaisProvincia()
        {
            InitializeComponent();
            cbxProvincias.SelectedIndex = -1;
            cbxPaises.SelectedIndex = -1;
            this.Text = "Elección Provincia";

        }

        private async void FrmEleccionPaisProvincia_Load(object sender, EventArgs e)
        {

            string url = "https://localhost:44381/api/Equipos/paises";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<Pais> lstP = JsonConvert.DeserializeObject<List<Pais>>(resultado);
            cbxPaises.DataSource = lstP;
            cbxPaises.DisplayMember = "Nombre";
            cbxPaises.ValueMember = "IdPais";

            string url2 = "https://localhost:44381/api/Equipos/provincias";
            var resultado2 = await ClienteSingleton.GetInstancia().GetAsync(url2);
            List<Provincia> lstPr = JsonConvert.DeserializeObject<List<Provincia>>(resultado2);

            cbxProvincias.Enabled = false;
            cbxProvincias.SelectedValue = -1;
            cbxProvincias.DataSource = lstPr;
            cbxProvincias.DisplayMember = lstPr.ToString(); // "Nombre";
            //cbxProvincias.ValueMember = "IdProvincia";

        }

        private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbxPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija una provincia luego de elegir un país!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxPaises.Focus();
                return;
            }
            Pais oPais = (Pais)cbxPaises.SelectedItem;
            IdProvincia = oPais.IDPais;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
