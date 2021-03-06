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
    public partial class FrmEleccionPaisProv : Form
    {
        public int IdEleccion { get; set; }
        TablasSoporte tabla;

        public FrmEleccionPaisProv(TablasSoporte tabla)
        {
            InitializeComponent();
            this.tabla = tabla;

            if (tabla == TablasSoporte.provincias) 
            {

                lblTitulo.Text = "";
                this.Text = "Elija a que Pais corresponde su Provincia";
                lblEleccion.Text = "Elija a que País corresponde\nsu Provincia:"; 

            }
            if (tabla == TablasSoporte.localidades)
            {
                lblTitulo.Text = "";
                this.Text = "Elija a que Provincia corresponde su Localidad";
                lblEleccion.Text = "Elija a que Provincia\ncorresponde su Localidad:";
            }
    
        }

        private async void FrmEleccionPais_Load(object sender, EventArgs e)
        {
            if(tabla == TablasSoporte.provincias)
            {
                string url = "https://localhost:44381/api/Equipos/paises";
                var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
                List<Pais> lstP = JsonConvert.DeserializeObject<List<Pais>>(resultado);
                cbxPaises.DataSource = lstP;
                cbxPaises.DisplayMember = "Nombre";
                cbxPaises.ValueMember = "IdPais";

            }
            if(tabla == TablasSoporte.localidades)
            {
                string url1 = "https://localhost:44381/api/Equipos/provincias";
                var resultado = await ClienteSingleton.GetInstancia().GetAsync(url1);
                List<Provincia> lstP = JsonConvert.DeserializeObject<List<Provincia>>(resultado);
                cbxPaises.DataSource = lstP;
                cbxPaises.DisplayMember = lstP.ToString();                
                
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cbxPaises.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija una opción!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxPaises.Focus();
                return;
            }

            if (tabla == TablasSoporte.provincias)
            {
                Pais oPais = (Pais)cbxPaises.SelectedItem;
                IdEleccion = oPais.IDPais;
            }
            if (tabla == TablasSoporte.localidades)
            {
                Provincia oProv = (Provincia)cbxPaises.SelectedItem;
                IdEleccion = oProv.IDProvincia;

            }
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
