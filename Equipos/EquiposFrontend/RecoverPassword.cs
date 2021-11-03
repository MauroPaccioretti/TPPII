using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquiposBackend.Dominio;
using EquiposBackend.Negocio;
using System.Text.RegularExpressions;
using EquiposFrontend.Cliente;
using Newtonsoft.Json;

namespace EquiposFrontend
{
    public partial class RecoverPassword : Form
    {
        //private IAplicacion service;
        //Usuario user = new Usuario();

        public RecoverPassword()
        {
            InitializeComponent();
            //service = new ImpFactoryAplicacion().CrearService();
            lblResultado.Text = "";
        }

        private async void btnSendEmailRecover_Click(object sender, EventArgs e)
        {
            if (ValidateEmail())
            {
                lblResultado.Text = "";
                //user.Email = textBoxUserRequest.Text;
                string url = "https://localhost:44381/api/Usuarios/recoverPass?userRequesting=" + textBoxUserRequest.Text;
                var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
                //string mensaje = JsonConvert.DeserializeObject<string>(resultado);

                //var result = service.RecoverPassword(user.Email);

                //lblResultado.Text = result;
                lblResultado.Text = resultado;
            }
            else
            {
                if (textBoxUserRequest.Text != string.Empty)
                {
                    lblResultado.Text = "Please enter a Email Address Valid";
                }
                else
                {
                    lblResultado.Text = "Please enter a email";
                }
                
            }
            
                        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            return;
        }

        private bool ValidateEmail()
        {
            string email = textBoxUserRequest.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
                
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            return;            
            
        }
    }
}
