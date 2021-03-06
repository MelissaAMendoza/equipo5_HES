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
    public partial class inicioAdmi : Form
    {
        //Visualiza el tipo de usuario y el nombre del usuario
        public inicioAdmi(string nombre)
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

        private void btnAdmMed_Click(object sender, EventArgs e)
        {
            AdmMed administracion = new AdmMed();
            administracion.Show();
        }

        private void btnGR_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenRep reportes = new GenRep();
            reportes.Show();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
