using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftHES
{
    //Creamos una variable por cada campo de mi tabla 
    public class users
    {
        int id, idTipo;
        string nombre, usuario, password, conPassword;

        //Nos crea todos los metodos set y get para establecer o retornar el valor de cada una de las propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public int Id { get => id; set => id = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }


    }
}
