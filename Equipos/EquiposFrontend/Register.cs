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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquiposFrontend
{
    public partial class Register : Form
    {

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
            Usuario usuario = new Usuario();
            List<Usuario> usuarios = new();
            
            if (textBoxUsername.Text != string.Empty)
            {
                usuario.User = textBoxUsername.Text;                

                if (textBoxPass.Text != string.Empty)
                {
                    usuario.Pass = textBoxPass.Text;
                    

                    if (textBoxEmail.Text != string.Empty && ValidateEmail())
                    {
                        usuario.Email = textBoxEmail.Text;

                        usuarios.Add(usuario);

                        string datosJSON = JsonConvert.SerializeObject(usuario);
                        string url = "https://localhost:44381/api/Usuarios/register";
                        await ClienteSingleton.GetInstancia().PostAsync(url,datosJSON);

                        if (usuarios.Count > 0)
                        {
                            DialogResult result = MessageBox.Show("Registrado con nombre de usuario: " + usuario.User.ToString());
                            if (result == DialogResult.OK)
                            {
                                
                                Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar");
                            return;
                        }
                        
                    }
                    else
                    {
                        MsgErrorEmail("Porfavor ingrese un email valido");
                        textBoxEmail.Focus();
                    }
                }
                else
                {
                    MsgErrorPass("Porfavor ingrese una contraseña");
                    textBoxPass.Focus();

                }
            }
            else
            {
                MsgErrorUser("Porfavor ingrese un Usuario");
                textBoxUsername.Focus();
            }
        }

        private bool ValidateEmail()
        {
            string email = textBoxEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;

        }
    }
}
