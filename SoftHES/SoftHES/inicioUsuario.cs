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
            lblMensaje.Text = "BIENVENIDO!  " + nombre;
            

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
            this.Hide();
            MiUsuario usuario = new MiUsuario();
            usuario.Show();
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegCita1 reg = new RegCita1();
            reg.Show();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsCita consulta = new ConsCita();
            consulta.Show();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
