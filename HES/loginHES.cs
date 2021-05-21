using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HES
{
    public partial class loginHES : Form
    {
        public loginHES()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        string contraseña;
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            inicioUsuario usuario = new inicioUsuario();
            usuario.Show();*/

            string user = txtUser.Text;
            string pass = txtPass.Text;
            string url = "C:\\BD\\" + user + ".txt";

            if (File.Exists(url))
            {
                contraseña = File.ReadAllText(url);

                if (pass.Equals(contraseña))
                {
                    MessageBox.Show("Iniciando sesión" /*MessageBoxButtons.OK, MessageBoxIcon.Exclamation*/);
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }

            }
            else
            {
                MessageBox.Show("No se reconoce el usuario");
            }

        }

        

        private void btnMin_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
           
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.CornflowerBlue;
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loginHES_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPass.Text;
            string url = "C\\BD\\" + user + ".txt";

            if (File.Exists(url))
            {
                MessageBox.Show("No es posible registrar este usuario");

            }
            else
            {
                File.WriteAllText(url, password);

                MessageBox.Show("Registro Exitoso");
                txtUser.Text = " ";
                txtPass.Text = " ";
            }
        }
    }
}
