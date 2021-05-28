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
            lblDoc.Text = "BIENVENIDO!" + nombre;
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            ActDatos act = new ActDatos();
            act.Show();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            AgCitas agenda = new AgCitas();
            agenda.Show();
        }

        private void btnHC_Click(object sender, EventArgs e)
        {
            HistClin historia = new HistClin();
            historia.Show();
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            RegCita reg = new RegCita();
            reg.Show();
        }

        private void btnMD_Click(object sender, EventArgs e)
        {
            ModDisp disp = new ModDisp();
            disp.Show();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
