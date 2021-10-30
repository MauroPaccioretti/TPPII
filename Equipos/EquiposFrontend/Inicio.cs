using EquiposBackend.Dominio;
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
    public partial class Inicio : Form
    {
        Usuario oUsuario;
        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            oUsuario = usuario; 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void Inicio_Load(object sender, EventArgs e)
        {

                        
        }

        private void Principal_FormClosing(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this service.", "Goodbye.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
