using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftHES
{
    public partial class inicioUsuario : Form
    {
        //Visualiza el tipo de usuario y el nombre del usuario
        public inicioUsuario(string nombre)
        {
            InitializeComponent();
            lblUs.Text = "BIENVENIDO!" + nombre;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMU_Click(object sender, EventArgs e)
        {
            MiUs MiUs = new MiUs();
            MiUs.Show();
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            RegCita reg = new RegCita();
            reg.Show();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            ConsCita consulta = new ConsCita();
            consulta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
