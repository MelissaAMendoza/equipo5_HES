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
    public partial class AdmMed : Form
    {
        public AdmMed()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtras_Click(object sender, EventArgs e, string nombre)
        {
            this.Hide();
            inicioAdmi inicio = new inicioAdmi(nombre);
            inicio.Show();
        }

        private void btnRM_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegMed reg = new RegMed();
            reg.Show();
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsCons cons = new ConsCons();
            cons.Show();
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegCons reg = new RegCons();
            reg.Show();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsCons cons = new ConsCons();
            cons.Show();
        }
    }
}
