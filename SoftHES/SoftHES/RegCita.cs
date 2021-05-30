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
    public partial class RegCita : Form
    {
        public RegCita()
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //string query = "insert into usuarios values(\"" + TbxCi.Text + "\",\"" + TbxNombre.Text + "\",\"" + TbxApellido.Text + "\",\"" + TbxContraseña.Text + "\",\"" + TbxEdad.Text + "\",\"" + TbxDireccion.Text + "\",\"" + TbxCorreo.Text + "\",\"" + TbxTelefono.Text + "\",\" paciente\")";
        }
    }
}
