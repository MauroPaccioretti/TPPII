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
        Usuario usuario = new Usuario();
        bool forcedLogin = false;
        public Login()
        {

            InitializeComponent();
            //service = new ImpFactoryAplicacion().CrearService();
            

        }



        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            List<string> lstDatos = new();

            if (textBoxUsername.Text != string.Empty )
            {
                usuario.User = textBoxUsername.Text;
                lstDatos.Add(textBoxUsername.Text);

                if (textBoxPassword.Text != string.Empty)
                {
                    usuario.Pass = textBoxPassword.Text;
                    lstDatos.Add(textBoxPassword.Text);

                    string datosJSON = JsonConvert.SerializeObject(lstDatos);
                    string url = "https://localhost:44381/api/Usuarios/login";
                    

                    var resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJSON);

                    bool validLogIn = JsonConvert.DeserializeObject<bool>(resultado);

                    if (textBoxUsername.Text == "123") //inicio hardCodeado
                        forcedLogin = true;


                    //var validLogin = service.Login(usuario.User, usuario.Pass);

                    if (validLogIn == true || forcedLogin)
                    {                        
                        Inicio mainMenu = new Inicio(usuario);
                        mainMenu.TopMost = true;
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MsgErrorIncorrect("Usuario o Contraseña incorrecto.");
                        MsgErrorUser("");
                        MsgErrorPass("");
                        textBoxPassword.Clear();
                        textBoxUsername.Focus();
                        
                    }

                }
                else
                {
                    MsgErrorPass("Por favor, ingrese una contraseña");

                }
            }
            else
            {
                MsgErrorUser("Por favor, ingrese un usuario");
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
            this.Opacity = 0.3;
            var recoverPassword = new RecoverPassword();
            recoverPassword.ShowDialog();
            this.Opacity = 1;
            
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la aplicación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
