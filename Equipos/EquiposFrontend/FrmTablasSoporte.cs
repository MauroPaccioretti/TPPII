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

    public enum TablasSoporte {
        paises,
        provincias,
        localidades,
        tipoDocumentos,
        tipoCompromisos
    }

    public enum Accion
    {
        Agregar,
        Modificar
    }

    public partial class FrmTablasSoporte : Form
    {

        private TablasSoporte modo;
        private Accion accion;
        private string modoString;
        public FrmTablasSoporte(TablasSoporte modo, Accion accion)
        {
            InitializeComponent();
            this.modo = modo;
            this.accion = accion;
            this.Text = accion.ToString() + " Nombre de " + EnumATexto(modo);
            modoString = EnumATexto(modo);
            btnAceptar.Text = accion.ToString();
            
        }

        public static string EnumATexto(TablasSoporte e)
        {
            switch (e)
            {
                case TablasSoporte.paises:
                    return "Paises";
                case TablasSoporte.provincias:
                    return "Provincias";
                case TablasSoporte.localidades:
                    return "Localidades";
                case TablasSoporte.tipoDocumentos:
                    return "Tipo de Documento";
                case TablasSoporte.tipoCompromisos:
                    return "Tipo de Compromiso";
            }
            return "";
        }

        private async void Modificar_PPL_Frm_Load(object sender, EventArgs e)
        {
            switch (accion)
            {
                case Accion.Agregar:
                    lblEleccion.Text = "Verifique que el elemento no se encuentre en la lista:" ;
                    break;
                case Accion.Modificar:
                    lblEleccion.Text = "Elija elemento a modificar:";
                    break;
            }




            string url = "https://localhost:44381/api/Equipos/" + modo.ToString();
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);


            switch (modo)
            {
                case TablasSoporte.paises:
                    List<Pais> lstP = JsonConvert.DeserializeObject<List<Pais>>(resultado);
                    cmbPPL.DataSource = lstP;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdPais";
                    break;
                case TablasSoporte.provincias:
                    List<Provincia> lstPr = JsonConvert.DeserializeObject<List<Provincia>>(resultado);
                    cmbPPL.DataSource = lstPr;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdProvincia";
                    break;
                case TablasSoporte.localidades:
                    List<Localidad> lstLoc = JsonConvert.DeserializeObject<List<Localidad>>(resultado);
                    cmbPPL.DataSource = lstLoc;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdLocalidad";
                    break;
                case TablasSoporte.tipoDocumentos:
                    List<TiposDocumentos> lstTipoDoc = JsonConvert.DeserializeObject<List<TiposDocumentos>>(resultado);
                    cmbPPL.DataSource = lstTipoDoc;
                    cmbPPL.DisplayMember = "TipoDoc";
                    cmbPPL.ValueMember = "CodTipoDoc";
                    break;
                case TablasSoporte.tipoCompromisos:
                    List<TipoCompromisos> lstTipoCompromiso = JsonConvert.DeserializeObject<List<TipoCompromisos>>(resultado);
                    cmbPPL.DataSource = lstTipoCompromiso;
                    cmbPPL.DisplayMember = "NombreCompromiso";
                    cmbPPL.ValueMember = "CodCompromiso";
                    break;
                
            }

            

        }

        private void cmbPPL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor inserte un nombre para " + accion.ToString().ToLower() + ".", "Inserte un nombre.",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }

            string mensaje = "Esta seguro que desea " + accion.ToString().ToLower() + " ";

            switch (accion)
            {
                case Accion.Agregar:
                    mensaje += txtNombre.Text + " a la lista de " + EnumATexto(modo) + "?";
                    break;
                case Accion.Modificar:
                    mensaje += cmbPPL.GetItemText(cmbPPL.SelectedItem) + " por " + txtNombre.Text + "?";
                    break;
            }

            if (MessageBox.Show(mensaje, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
            }
        }


    }
}
