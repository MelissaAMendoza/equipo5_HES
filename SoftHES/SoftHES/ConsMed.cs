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
    public partial class ConsMed : Form
    {
        public ConsMed()
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
            this.Hide();
            AdmMed inicio = new AdmMed();
            inicio.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Hacemos Visible la lista de los Doctores en la base de datos
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = softhes; Uid = root; pwd = 123456;");

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Select * From plantel_medico_vistausuario", conexion);

            //Pasamos todos los datos a nuestro dataset y posteriormente mostrarlo en nuestro DataGridView
            MySqlDataAdapter con = new MySqlDataAdapter(cmd);

            DataSet dt = new DataSet();
            con.Fill(dt);

            dataGridView1.DataSource = dt.Tables[0];
            conexion.Close();
        }
    }
}
