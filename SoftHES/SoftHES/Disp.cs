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
    public partial class Disp : Form
    {
        public Disp()
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

        private void btnAtras_Click(object sender, EventArgs e,string nombre)
        {
            this.Hide();
            inicioDoc inicio = new inicioDoc(nombre);
            inicio.Show();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
