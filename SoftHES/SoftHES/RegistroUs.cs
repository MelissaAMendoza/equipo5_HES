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
    public partial class RegistroUs : Form
    {
        public RegistroUs()
        {
            InitializeComponent();
        }

        private void RegistroUs_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            LoginHES login = new LoginHES();
            login.Show();
            this.Hide();

        }
    }
}
