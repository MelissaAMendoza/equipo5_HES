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
    public partial class Doc : Form
    {
        //Visualiza el tipo de usuario y el nombre del usuario
        public Doc(string nombre)
        {
            InitializeComponent();
            lblDoc.Text = nombre;
        }

       
    }
}
