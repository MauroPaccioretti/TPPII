using EquiposBackend.Dominio;
using EquiposFrontend.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace EquiposFrontend
{



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



        private void Modificar_PPL_Frm_Load(object sender, EventArgs e)
        {
            switch (accion)
            {
                case Accion.Agregar:
                    lblEleccion.Text = "Verifique que el elemento no se encuentre en la lista:";
                    break;
                case Accion.Modificar:
                    lblEleccion.Text = "Elija elemento a modificar:";
                    break;
            }

            CargarComboAsync();
                        
        }

        private async void CargarComboAsync()
        {
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


        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor inserte un nombre para " + accion.ToString().ToLower() + ".", "Inserte un nombre.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                string url = "https://localhost:44381/api/Equipos/";                                
                string resultado;              
                string datosJSON;

                switch (accion)
                {
                    case Accion.Agregar:
                        switch (tabla)
                        {
                            case TablasSoporte.paises:

                                url += "insertarPais";
                                Pais oPais = new Pais();
                                oPais.Nombre = txtNombre.Text;
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, JsonConvert.SerializeObject(oPais));
                                
                                MessageBox.Show(resultado, "Resultado");
                                
                                break;

                            case TablasSoporte.provincias:

                                url += "insertarProvincia";

                                Provincia oProvincia = new Provincia();
                                oProvincia.Nombre = txtNombre.Text;

                                FrmEleccionPaisProv frmPais = new FrmEleccionPaisProv(TablasSoporte.provincias);
                                frmPais.ShowDialog();
                                oProvincia.Pais.IDPais = frmPais.IdEleccion;
                                datosJSON = JsonConvert.SerializeObject(oProvincia);
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);
                               
                                MessageBox.Show(resultado, "Resultado");
                                break;

                            case TablasSoporte.localidades:

                                url += "insertarLocalidad";

                                Localidad oLoc = new Localidad();
                                oLoc.Nombre = txtNombre.Text;

                                FrmEleccionPaisProv frmProv = new FrmEleccionPaisProv(TablasSoporte.localidades);
                                frmProv.ShowDialog();
                                oLoc.Provincia.IDProvincia = frmProv.IdEleccion;
                                datosJSON = JsonConvert.SerializeObject(oLoc);
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);

                                MessageBox.Show(resultado, "Resultado");
                                break;

                            case TablasSoporte.tipoDocumentos:

                                url += "insertarTipoDocumento";

                                TiposDocumentos oTdoc = new TiposDocumentos();
                                oTdoc.TipoDoc = txtNombre.Text;
                                datosJSON = JsonConvert.SerializeObject(oTdoc);
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);

                                MessageBox.Show(resultado, "Resultado");
                                break;

                            case TablasSoporte.tipoCompromisos:

                                url += "insertarTipoCompromiso";

                                TipoCompromisos oTC = new TipoCompromisos();
                                oTC.NombreCompromiso = txtNombre.Text;
                                datosJSON = JsonConvert.SerializeObject(oTC);
                                resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);

                                MessageBox.Show(resultado, "Resultado");
                                break;
                        }
                        break;

                    case Accion.Modificar:
                        switch (tabla)
                        {
                            case TablasSoporte.paises:

                                url += "editarPais";

                                Pais oPais = new Pais();
                                oPais.Nombre = txtNombre.Text;
                                oPais.IDPais = (int)cmbPPL.SelectedValue;
                                resultado = await ClienteSingleton.GetInstancia().PutAsync(url, JsonConvert.SerializeObject(oPais));
                                
                                MessageBox.Show(resultado, "Resultado");
                                break;

                            case TablasSoporte.provincias:

                                url += "editarProvincia";

                                Provincia oProvincia = new Provincia();
                                oProvincia.Nombre = txtNombre.Text;
                                FrmEleccionPaisProv frmPais = new FrmEleccionPaisProv(TablasSoporte.provincias);
                                frmPais.ShowDialog();
                                oProvincia.Pais.IDPais = frmPais.IdEleccion;
                                datosJSON = JsonConvert.SerializeObject(oProvincia);
                                resultado = await ClienteSingleton.GetInstancia().PutAsync(url, datosJSON);
                       
                                MessageBox.Show(resultado, "Resultado");
                                break;

                            case TablasSoporte.localidades:

                                url += "editarLocalidad";

                                Localidad oLoc = new Localidad();

                                oLoc = (Localidad)cmbPPL.SelectedItem;
                                oLoc.Nombre = txtNombre.Text;
                                FrmEleccionPaisProv frmProv = new FrmEleccionPaisProv(TablasSoporte.localidades);
                                frmProv.ShowDialog();
                                //Provincia oProv = new Provincia();
                                oLoc.Provincia.IDProvincia = frmProv.IdEleccion;
                                //oLoc.Provincia = oProv;
                                datosJSON = JsonConvert.SerializeObject(oLoc);
                                resultado = await ClienteSingleton.GetInstancia().PutAsync(url, datosJSON);

                                MessageBox.Show(resultado, "Resultado");
                                break;

                            case TablasSoporte.tipoDocumentos:

                                url += "editarTipoDocumento";

                                TiposDocumentos oTdoc = new TiposDocumentos();
                                oTdoc.TipoDoc = txtNombre.Text;
                                oTdoc.CodTipoDoc = (int)cmbPPL.SelectedValue;
                                datosJSON = JsonConvert.SerializeObject(oTdoc);
                                resultado = await ClienteSingleton.GetInstancia().PutAsync(url, datosJSON);

                                MessageBox.Show(resultado, "Resultado");
                                break;

                            case TablasSoporte.tipoCompromisos:

                                url += "editarTipoCompromisos";

                                TipoCompromisos oTC = new TipoCompromisos();
                                oTC.NombreCompromiso = txtNombre.Text;
                                oTC.CodCompromiso = (int)cmbPPL.SelectedValue;
                                datosJSON = JsonConvert.SerializeObject(oTC);
                                resultado = await ClienteSingleton.GetInstancia().PutAsync(url, datosJSON);

                                MessageBox.Show(resultado, "Resultado");
                                break;

                        }
                        break;
                }

            }
            CargarComboAsync();
            txtNombre.Text = "";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
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
            Dispose();
        }
    }
}
