using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquiposBackend.Dominio;
using EquiposBackend.Negocio;
using EquiposFrontend.Cliente;
using Newtonsoft.Json;

namespace EquiposFrontend
{
    public partial class Login : Form
    {
        //private IAplicacion service;
        //Usuario usuario = new Usuario();

        public Login()
        {
            InitializeComponent();
            //service = new ImpFactoryAplicacion().CrearService();
            
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            List<string> lst = new();

            if (textBoxUsername.Text != string.Empty )
            {
                //usuario.User = textBoxUsername.Text;
                lst.Add(textBoxUsername.Text);

                if (textBoxPassword.Text != string.Empty)
                {
                    //usuario.Pass = textBoxPassword.Text;
                    lst.Add(textBoxPassword.Text);
                    
                    

                    string filtrosJSON = JsonConvert.SerializeObject(lst);
                    string url = "https://localhost:44381/api/Usuarios/login";

                    var resultado = await ClienteSingleton.GetInstancia().PostAsync(url, filtrosJSON);

                    bool validLogIn = JsonConvert.DeserializeObject<bool>(resultado);
                    

                    //var validLogin = service.Login(usuario.User, usuario.Pass);
                    
                    if (validLogIn == true)
                    {
                        Form1 mainMenu = new Form1();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MsgErrorIncorrect("Incorrect Username or Password entered. Please try again.");
                        MsgErrorUser("");
                        MsgErrorPass("");
                        textBoxPassword.Clear();
                        textBoxUsername.Focus();
                        
                    }

                }
                else
                {
                    MsgErrorPass("Please enter Password");

                }
            }
            else
            {
                MsgErrorUser("Please enter Username");
            }



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
        private void MsgErrorIncorrect(string msg)
        {
            lblErrorIncorrect.Text = msg;
            lblErrorIncorrect.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            lblErrorIncorrect.Visible = false;
            lblErrorUsername.Visible = false;
            lblErrorPass.Visible = false;
            this.Show();
            textBoxUsername.Focus();


        }

        private void linklblOlvidoContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new RecoverPassword();
            recoverPassword.ShowDialog();
        }
    }
}
