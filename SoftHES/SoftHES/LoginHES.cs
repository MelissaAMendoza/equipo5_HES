using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace SoftHES
{

    public partial class LoginHES : Form
    { 

        public LoginHES()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            logear(this.txtUser.Text, this.txtPass.Text);
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            RegistroUs registro = new RegistroUs();
            registro.Show();

        }

        public void logear(string usuario, string contrasena)
        {
            //Conectamos con nuestra Base de Datos 
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = softhes; Uid = root; pwd = 123456;");

            //Manejo de Errores
            //Señala un bloque de instrucciones a intentar (try), y especifica una respuesta si se produce una excepcion 
            try
            {
                //Abrimos la conexion
                conexion.Open();
                //Creamos un comando sql y le pasamos nuestra consulta que enviaremos a nuestra base de datos, parametrzamos nuestros datos
                MySqlCommand cmd = new MySqlCommand("SELECT nombre, tipoUsuario FROM usuarios WHERE usuario = @usuario AND contrasena = @contrasena", conexion);
                //Agregamos parametros a nuestro comando 
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                //Creamos un objeto de tipo SqlDataAdapter en donde le pasaremos nuestro comando creado
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                //Creamos un objeto de tipo datatable para llenarlas con los datos de la tabla 
                DataTable dt = new DataTable();
                //Llenamos con los datos de la tabla 
                adp.Fill(dt);

                //Verificamos si nuestar consulta nos devuelve filas entonces quiere decir que hay algun usuario que coincida 
                //como esos criteros del usuario y la contrasena

                //Si nuestro datatable contiene columnas quier decir que si se encontro datos 

                if (dt.Rows.Count == 1)
                {
                    //Evaluaremos que tipo de usuario esta ingresando 
                    this.Hide();

                    if (dt.Rows[0][1].ToString() == "USUARIO")
                    {
                        new inicioUsuario(dt.Rows[0][0].ToString()).Show();
                        
                    }
                    else
                    {
                        if (dt.Rows[0][1].ToString() == "ADMINISTRADOR")
                        {
                            new inicioAdmi(dt.Rows[0][0].ToString()).Show();
                        }
                        else
                        {
                            if (dt.Rows[0][1].ToString() == "DOCTOR")
                            {
                                new inicioDoc(dt.Rows[0][0].ToString()).Show();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }


        }

        
    }
}
