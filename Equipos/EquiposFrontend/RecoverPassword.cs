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

namespace EquiposFrontend
{
    public partial class RecoverPassword : Form
    {
        private IAplicacion service;
        Usuario user = new Usuario();

        public RecoverPassword()
        {
            InitializeComponent();
            service = new ImpFactoryAplicacion().CrearService();
            lblResultado.Text = "";
        }

        private void btnSendEmailRecover_Click(object sender, EventArgs e)
        {
            if (ValidateEmail())
            {
                lblResultado.Text = "";
                user.Email = textBoxUserRequest.Text;
                var result = service.RecoverPassword(user.Email);
                lblResultado.Text = result;

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
            Close();
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

    }
}
