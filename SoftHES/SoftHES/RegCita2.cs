using MySql.Data.MySqlClient;
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
    public partial class RegCita2 : Form
    {
        public RegCita2()
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

        private void btnAtras_Click(object sender, EventArgs e,string nombre)
        {
            this.Hide();
            inicioUsuario inicio = new inicioUsuario(nombre);
            inicio.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*switch(caseSwitch)
            {
                 case 1:
                     Console.WriteLine("Case 1");
                       break;
                 case 2:
                    Console.WriteLine("Case 2");
                        break;
                 default:
                      Console.WriteLine("Default case");
                        break;
            }*/

        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = softhes; Uid = root; pwd = 123456;");

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Select * From plantel_medico_vistausuario", conexion);

            //Pasamos todos los datos a nuestro dataset y posteriormente mostrarlo en nuestro DataGridView
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);

            DataSet dt = new DataSet();
            con.Fill(dt);

            dataGridView2.DataSource = dt.Tables[0];
            conexion.Close();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegCita1 reg = new RegCita1();
            reg.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
