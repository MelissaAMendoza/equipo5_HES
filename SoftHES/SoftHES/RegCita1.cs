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
    public partial class RegCita1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = softhes; Uid = root; pwd = 123456;");

        public RegCita1()
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCI.Text == "" || txtTelefono.Text == "" )
            {
                MessageBox.Show("No se completaron todos los Campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Abrimos nuestra conexion a Mysql 
                conexion.Open();

                string nombe = txtNombre.Text;
                string apellido = txtApellido.Text;
                int ced = int.Parse(txtCI.Text);
                int telefono = int.Parse(txtTelefono.Text);
                //string sector = 
                //int fecha = 
                //int hora =

                
                //Vamos cargando los datos ingresados por los usuarios a traves de los textboxs
                string query = "insert into reg_cita values(\"" + txtNombre.Text + "\",\"" + txtApellido.Text + "\",\"" + txtCI.Text + "\",\"" + txtTelefono.Text + "\")";
                MessageBox.Show("exito");

                /* MySqlCommand cmd = new MySqlCommand("Select * From usuarios", conexion);

                //Pasamos todos los datos a nuestro dataset y posteriormente mostrarlo en nuestro DataGridView
                MySqlDataAdapter con = new MySqlDataAdapter(cmd);

                DataSet dt = new DataSet();
                con.Fill(dt);

                dataGridView1.DataSource = dt.Tables[0];
                conexion.Close();*/

                this.Hide();
                RegCita2 reg = new RegCita2();
                reg.Show();

            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //inicioUsuario inicio = new inicioUsuario();
            //inicio.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
