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

    public enum PPL {
        pais,
        provincia,
        localidad,
        tipoDocumentos,
        tipoCompromisos
    }


    public partial class Modificar_PPL_Frm : Form
    {

        private PPL modo;
        private string modoString;
        public Modificar_PPL_Frm(PPL modo)
        {
            InitializeComponent();
            this.modo = modo;
            this.Text = "Modificar Nombre de " + EnumATexto(modo);
            modoString = EnumATexto(modo);
                    
        }

        public static string EnumATexto(PPL e)
        {
            switch (e)
            {
                case PPL.pais:
                    return "Paises";
                case PPL.provincia:
                    return "Provincias";
                case PPL.localidad:
                    return "Localidades";
                case PPL.tipoDocumentos:
                    return "Tipo de Documento";
                case PPL.tipoCompromisos:
                    return "Tipo de Compromiso";
            }
            return "";
        }

        private async void Modificar_PPL_Frm_Load(object sender, EventArgs e)
        {
            string url = "https://localhost:44381/api/Equipos/" + modo.ToString();
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);


            switch (modo)
            {
                case PPL.pais:
                    List<Pais> lstP = JsonConvert.DeserializeObject<List<Pais>>(resultado);
                    cmbPPL.DataSource = lstP;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdPais";
                    break;
                case PPL.provincia:
                    List<Provincia> lstPr = JsonConvert.DeserializeObject<List<Provincia>>(resultado);
                    cmbPPL.DataSource = lstPr;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdProvincia";
                    break;
                case PPL.localidad:
                    List<Localidad> lstLoc = JsonConvert.DeserializeObject<List<Localidad>>(resultado);
                    cmbPPL.DataSource = lstLoc;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdLocalidad";
                    break;
                case PPL.tipoDocumentos:
                    List<TiposDocumentos> lstTipoDoc = JsonConvert.DeserializeObject<List<TiposDocumentos>>(resultado);
                    cmbPPL.DataSource = lstTipoDoc;
                    cmbPPL.DisplayMember = "TipoDoc";
                    cmbPPL.ValueMember = "CodTipoDoc";
                    break;
                case PPL.tipoCompromisos:
                    List<TipoCompromisos> lstTipoCompromiso = JsonConvert.DeserializeObject<List<TipoCompromisos>>(resultado);
                    cmbPPL.DataSource = lstTipoCompromiso;
                    cmbPPL.DisplayMember = "NombreCompromiso";
                    cmbPPL.ValueMember = "CodCompromiso";
                    break;
                default:
                    break;
            }



        }

        private void cmbPPL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
