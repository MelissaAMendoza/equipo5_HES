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

        private void btnReg_Click(object sender, EventArgs e)
        {
            //Creamos una instancia de la clase user, que contiene las propiedades get y set de la tabla
            users usuario = new users();
            usuario.Nombre = txtNA.Text;
            usuario.Usuario = txtUs.Text;
            usuario.Password = txtPass.Text;
            usuario.ConPassword = txtCC.Text;

            try
            {

                Control control = new Control();

                string respuesta = control.ctrlRegistro(usuario);

                //Indica que hubo algun problema 
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
