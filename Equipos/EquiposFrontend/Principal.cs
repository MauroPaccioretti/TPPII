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

        private void Principal_Load (object sender, EventArgs e)
        {
            
            var frmLogin = new Login();
            
            frmLogin.ShowDialog();


        }


    }
}
