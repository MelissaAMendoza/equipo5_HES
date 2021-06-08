using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SoftHES
{
    public class ConexionReg
    {
        public static MySqlConnection getConnexion()
        {

            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = softhes; Uid = root; pwd = 123456;");

            return conexion;


        }

    }
}
