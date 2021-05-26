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
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace HES
{
    public partial class loginHES : Form
    {
        public loginHES()
        {
            InitializeComponent();
        }

        //string contraseña;
        /*private void btnAcceder_Click(object sender, EventArgs e)
        {
            //Conectamos con la base de datos
            
            conexion.Open();
            string consulta = "select users,pass from usarios where users='" + txtUser.Text + "'and pass='" + txtPass.Text + " ' ";

            SqlCommand cmd = new SqlCommand(consulta, conexion); 

            SqlDataReader registros = cmd.ExecuteReader();

            if (registros.Read())
            {
                inicioUsuario abrir = new inicioUsuario();
                abrir.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("El nombre de usuario o la contraseña no existen!");

            }


            //Conexion.Conectar();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT");

            /*string user = txtUser.Text;
            string pass = txtPass.Text;
            string url = "@\"" + user + ".txt\"";

            if (File.Exists(url))
            {
                contraseña = File.ReadAllText(url);

                if (pass.Equals(contraseña))
                {
                    MessageBox.Show("Iniciando sesión" MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        }*/

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            registrarUsuario nuevo = new registrarUsuario();
            nuevo.Show();
            this.Hide();

            /*string user = txtUser.Text;
            string password = txtPass.Text;
            string url = "@\"" + user + ".txt\"";

            if (File.Exists(url))
            {
                MessageBox.Show("No es posible registrar este usuario");

            }
            else
            {
                File.WriteAllText(url, password);

                this.Hide();
                inicioUsuario usuario = new inicioUsuario();
                usuario.Show();

                //MessageBox.Show("Registro Exitoso");
                txtUser.Text = " ";
                txtPass.Text = " ";
            }*/
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

        private void loginHES_Load(object sender, EventArgs e)
        {
            //Conexion.Conectar();
            //MessageBox.Show("Conexion Establecida");
        }

        SqlConnection conexion = new SqlConnection("server = DESKTOP-AENRCM9\\LOCALDB#0BFC5671; database = Hospital; integrated security = true");

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT USUARIO,CONTRASEÑA FROM Usuario WHERE = @vusuario AND CONTRASEÑA = @vcontraseña",conexion);
            comando.Parameters.AddWithValue("@vusuario",txtUser.Text);
            comando.Parameters.AddWithValue("@vcontraseña", txtPass.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                conexion.Close();
                inicioUsuario inicio = new inicioUsuario();
                inicio.Show();

            }
        }
    }
}
