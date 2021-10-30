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
        Pais,
        Provincia,
        Localidad
    }


    public partial class Modificar_PPL_Frm : Form
    {

        private PPL modo;
        private string modoString;
        public Modificar_PPL_Frm(PPL modo)
        {
            InitializeComponent();
            this.modo = modo;
            this.Text = modo.ToString();
            modoString = EnumATexto(modo);
                    
        }

        public static string EnumATexto(PPL e)
        {
            switch (e)
            {
                case PPL.Pais:
                    return "paises";
                case PPL.Provincia:
                    return "provincias";
                case PPL.Localidad:
                    return "localidades";
                
            }
            return "";
        }

        private async void Modificar_PPL_Frm_Load(object sender, EventArgs e)
        {
            string url = "https://localhost:44381/api/Equipos/" + modoString;
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
                      

            switch (modo)
            { 
                case PPL.Pais:
                    List<Pais> lstP = JsonConvert.DeserializeObject<List<Pais>>(resultado);
                    cmbPPL.DataSource = lstP;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdPais";
                    break;
                case PPL.Provincia:
                    List<Provincia> lstPr = JsonConvert.DeserializeObject<List<Provincia>>(resultado);
                    cmbPPL.DataSource = lstPr;
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdProvincia";
                    break;
                case PPL.Localidad:
                    List<Localidad> lstLoc = JsonConvert.DeserializeObject<List<Localidad>>(resultado);
                    cmbPPL.DataSource = lstLoc; 
                    cmbPPL.DisplayMember = "Nombre";
                    cmbPPL.ValueMember = "IdLocalidad";
                    break;
                default:
                    break;
            }
            

            //cmbPPL.DataSource = lst;
        }

        private void cmbPPL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
