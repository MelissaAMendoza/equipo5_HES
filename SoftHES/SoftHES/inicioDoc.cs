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
    public partial class inicioDoc : Form
    {
        //Visualiza el tipo de usuario y el nombre del usuario
        public inicioDoc(string nombre)
        {
            InitializeComponent();
            lblMensaje.Text = "BIENVENIDO!  " + nombre;
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActDatos act = new ActDatos();
            act.Show();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgCitas agenda = new AgCitas();
            agenda.Show();
        }

        private void btnHC_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistClin1 historia = new HistClin1();
            historia.Show();
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Disp dis = new Disp();
            dis.Show();
        }


        private void btnCS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
