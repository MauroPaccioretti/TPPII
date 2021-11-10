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
using System.Threading;

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
            progressBar1.Visible = false;
        }

        public async Task<string> SendEmailAsync()
        {
            //lblResultado.Text = "";
            //user.Email = textBoxUserRequest.Text;
            string url = "https://localhost:44381/api/Usuarios/recoverPass?userRequesting=" + textBoxUserRequest.Text;
            string resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            return resultado;
            //lblResultado.Text = resultado;
        }

        private async void btnSendEmailRecover_Click(object sender, EventArgs e)
        {
            if (ValidateEmail())
            {
                string resultado = await SendEmailAsync();
                //string mensaje = JsonConvert.DeserializeObject<string>(resultado);

                //var result = service.RecoverPassword(user.Email);

                //lblResultado.Text = result;
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Show();

                
                if (resultado != null)
                {
                    lblResultado.Text = resultado;
                }

            }
            else
            {
                if (textBoxUserRequest.Text != string.Empty)
                {
                    lblResultado.Text = "Porfavor ingrese un email valido";
                }
                else
                {
                    lblResultado.Text = "Porfavor ingrese un email";
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            return;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            return;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 100)
            {
                btnSendEmailRecover.Text = "ENVIADO!!";
                textBoxUserRequest.Clear();
                textBoxUserRequest.Focus();
            }
        }
    }
}
