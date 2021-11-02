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
    public partial class Register : Form
    {
        Usuario usuario = new Usuario();

        public Register()
        {
            InitializeComponent();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MsgErrorUser(string msg)
        {
            lblErrorUsername.Text = msg;
            lblErrorUsername.Visible = true;
        }

        private void MsgErrorPass(string msg)
        {
            lblErrorPass.Text = msg;
            lblErrorPass.Visible = true;
        }
        private void MsgErrorEmail(string msg)
        {
            lblErrorEmail.Text = msg;
            lblErrorEmail.Visible = true;
        }


        private void btnBack_ClickAsync(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnRegister_ClickAsync(object sender, EventArgs e)
        {
            List<string> lstDatos = new();
            if (textBoxUsername.Text != string.Empty)
            {
                usuario.User = textBoxUsername.Text;
                lstDatos.Add(usuario.User);

                if (textBoxPass.Text != string.Empty)
                {
                    usuario.Pass = textBoxPass.Text;
                    lstDatos.Add(usuario.Pass);

                    if (textBoxEmail.Text != string.Empty)
                    {
                        usuario.Email = textBoxEmail.Text;
                        lstDatos.Add(usuario.Email);

                        string datosJSON = JsonConvert.SerializeObject(lstDatos);
                        string url = "https://localhost:44381/api/Usuarios/register";

                        var resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);

                        bool validLogIn = JsonConvert.DeserializeObject<bool>(resultado);

                        if (validLogIn)
                        {
                            MessageBox.Show("se registro");
                        }
                        else
                        {
                            MsgErrorEmail("Incorrect Username or Password entered. Please try again.");
                            MsgErrorUser("");
                            MsgErrorPass("");
                            textBoxPass.Clear();
                            textBoxUsername.Focus();

                        }
                    }
                    else
                    {
                        MsgErrorEmail("Please enter Email");
                        textBoxEmail.Focus();
                    }
                }
                else
                {
                    MsgErrorPass("Please enter Password");
                    textBoxPass.Focus();

                }
            }
            else
            {
                MsgErrorUser("Please enter Username");
                textBoxUsername.Focus();
            }
        }
    }
}
