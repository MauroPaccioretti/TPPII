using System;
using System.Windows.Forms;

namespace EquiposFrontend
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir de la aplicación?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Principal_Load (object sender, EventArgs e)
        {
            
            var frmLogin = new Login();
            
            frmLogin.ShowDialog();


        }


    }
}
