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
using System.Web;
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

        private TablasSoporte tabla;
        private Accion accion;
        private string modoString;
        public FrmTablasSoporte(TablasSoporte tabla, Accion accion)
        {
            InitializeComponent();
            this.tabla = tabla;
            this.accion = accion;
            this.Text = accion.ToString() + " Nombre de " + EnumATexto(tabla);
            lblTitulo.Text = accion.ToString() + " Nombre de " + EnumATexto(tabla);
            modoString = EnumATexto(tabla);
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




            string url = "https://localhost:44381/api/Equipos/" + tabla.ToString();
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            IEnumerable<object> lista;

            switch (tabla)
            {
                case TablasSoporte.paises:
                    /*List<Pais> lstP = JsonConvert.DeserializeObject<List<Pais>>(resultado);
                    cmbPPL.DataSource = lstP;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdPais";*/

                    lista = JsonConvert.DeserializeObject<List<Pais>>(resultado);
                    cmbPPL.DataSource = lista;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdPais";
                    break;
                case TablasSoporte.provincias:
                    //List<Provincia> lstPr = JsonConvert.DeserializeObject<List<Provincia>>(resultado);
                    lista = JsonConvert.DeserializeObject<List<Provincia>>(resultado);

                    //cmbPPL.DataSource = lstPr;
                    cmbPPL.DataSource = lista;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdProvincia";
                    break;
                case TablasSoporte.localidades:
                    //List<Localidad> lstLoc = JsonConvert.DeserializeObject<List<Localidad>>(resultado);
                    lista = JsonConvert.DeserializeObject<List<Localidad>>(resultado);
                    //cmbPPL.DataSource = lstLoc;
                    cmbPPL.DataSource = lista;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdLocalidad";
                    break;
                case TablasSoporte.tipoDocumentos:
                    //List<TiposDocumentos> lstTipoDoc = JsonConvert.DeserializeObject<List<TiposDocumentos>>(resultado);
                    //cmbPPL.DataSource = lstTipoDoc;
                    lista = JsonConvert.DeserializeObject<List<TiposDocumentos>>(resultado);
                    cmbPPL.DataSource = lista;
                    cmbPPL.DisplayMember = "TipoDoc";
                    cmbPPL.ValueMember = "CodTipoDoc";
                    break;
                case TablasSoporte.tipoCompromisos:
                    //List<TipoCompromisos> lstTipoCompromiso = JsonConvert.DeserializeObject<List<TipoCompromisos>>(resultado);
                    //cmbPPL.DataSource = lstTipoCompromiso;
                    lista = JsonConvert.DeserializeObject<List<TipoCompromisos>>(resultado);
                    cmbPPL.DataSource = lista;
                    cmbPPL.DisplayMember = "NombreCompromiso";
                    cmbPPL.ValueMember = "CodCompromiso";
                    break;                
            }                      

        }

        private void cmbPPL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private async void btnAceptar_Click(object sender, EventArgs e)
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
                    mensaje += txtNombre.Text + " a la lista de " + EnumATexto(tabla) + "?";
                    break;
                case Accion.Modificar:
                    mensaje += cmbPPL.GetItemText(cmbPPL.SelectedItem) + " por " + txtNombre.Text + "?";
                    break;
            }

            if (MessageBox.Show(mensaje, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //string nombreFormateado = HttpUtility.UrlPathEncode(txtNombre.Text);
                string url = "https://localhost:44381/api/Equipos/";

                bool aux = false;
                string resultado;
                //object objetoLocacion;
                string datosJSON;

                //bool aux = false;
                switch (accion)
                {
                    case Accion.Agregar:
                        switch (tabla)
                        {
                            case TablasSoporte.paises:
                                //"https://localhost:44381/api/Equipos/insertarPais?nombre=Chile"
                                url += "insertarPais";
                                Pais oPais = new Pais();
                                oPais.Nombre = txtNombre.Text;
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, JsonConvert.SerializeObject(oPais));
                                //aux = JsonConvert.DeserializeObject<bool>(resultado);
                                MessageBox.Show(resultado);
                                break;
                            case TablasSoporte.provincias:
                                //"https://localhost:44381/api/Equipos/insertarProvincia?nombre=Buenos%20Aires&idPais=1" 
                                url += "insertarProvincia" ;

                                Provincia oProvincia = new Provincia();
                                oProvincia.Nombre = txtNombre.Text;
                                FrmEleccionPaisProv frmPais = new FrmEleccionPaisProv(TablasSoporte.provincias);
                                frmPais.ShowDialog();
                                oProvincia.Pais.IDPais = frmPais.IdEleccion;
                                datosJSON = JsonConvert.SerializeObject(oProvincia);
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);
                                //aux = JsonConvert.DeserializeObject<bool>(resultado);
                                MessageBox.Show(resultado);

                                break;

                            case TablasSoporte.localidades:
                                //"https://localhost:44381/api/Equipos/insertarLocalidad?nombre=R%C3%ADo%20Cuarto&idProvincia=1"
                                url += "insertarLocalidad";

                                Localidad oLoc = new Localidad();
                                oLoc.Nombre = txtNombre.Text;

                                FrmEleccionPaisProv frmProv = new FrmEleccionPaisProv(TablasSoporte.localidades);
                                frmProv.ShowDialog();
                                oLoc.Provincia.IDProvincia = frmProv.IdEleccion;
                                datosJSON = JsonConvert.SerializeObject(oLoc);
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);

                                MessageBox.Show(resultado);
                                //aux = JsonConvert.DeserializeObject<bool>(resultado);


                                break;
                            case TablasSoporte.tipoDocumentos:
                                
                                break;
                            case TablasSoporte.tipoCompromisos:
                                
                                break;

                        }

                        break;
                    case Accion.Modificar:
                        switch (tabla)
                        {
                            case TablasSoporte.paises:

                                break;
                            case TablasSoporte.provincias:

                                break;
                            case TablasSoporte.localidades:

                                break;
                            case TablasSoporte.tipoDocumentos:

                                break;
                            case TablasSoporte.tipoCompromisos:

                                break;

                        }

                        break;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
