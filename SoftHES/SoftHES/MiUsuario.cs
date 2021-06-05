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
    public partial class MiUsuario : Form
    {
        public MiUsuario()
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = softhes; Uid = root; pwd = 123456;");

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Select * From usuarios",conexion);

            //Pasamos todos los datos a nuestro dataset y posteriormente mostrarlo en nuestro DataGridView
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);

            DataSet dt = new DataSet();
            con.Fill(dt);

            dataGridView1.DataSource = dt.Tables[0];
            conexion.Close();

        }


        private void btnAtras_Click(object sender, EventArgs e,string nombre)
        {
            this.Hide();
            inicioUsuario inicio = new inicioUsuario(nombre);
            inicio.Show();
        }
    }
}
