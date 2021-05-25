using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HES
{
    public partial class inicioUsuario : Form
    {
        public inicioUsuario()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void inicioUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            loginHES login = new loginHES();
            login.Show();
            this.Hide();

        }
    }
}
