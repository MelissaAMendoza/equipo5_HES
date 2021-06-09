using System;
using System.Security.Cryptography;
using System.Text;

namespace SoftHES
{
    //Intermediario entre la vista del form y las transacciones de MySQL
    public class Control
    {
        public string ctrlRegistro(users usuario)
        {
            TransMySql trans = new TransMySql();
            string respuesta = " ";

            //Primera validacion, valida si el usuario inserto o agrego todos los campos
            if(string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (usuario.Password == usuario.ConPassword)
                {
                    //Buscamos si es que ya existe algun usuario con esos datos
                    //El usuario ya existe y no se permite volver a registrar el usuario
                    if (trans.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else//El usuario aun no se ha registrado
                    {
                        //Convertimos el password, porque no lo podemos agregar asi como un texto normal, para que en la
                        //Base de datos si yo la consulto no pueda descrifrar cual es su contrasena. Esto para tener mayor
                        //seguridad en nuestras transacciones 

                        //Utilizamos un cifrado, SHA1 el cual convierte una cadena de texto en una mas grande como cifrandola
                        //para que no se sepa cual es este dato

                        usuario.Password = generarSHA1(usuario.Password);
                        trans.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {

            UTF32Encoding enc = new UTF32Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            //Convierte el string en SHA1 y asi poder cargarlo en la base de datos ya cifrada y no se pueda visualizar cual es la
            //contrasena del usuario
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i=0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }

                sb.Append(result[i].ToString("X"));

            }
            return sb.ToString();

        }
    }
}
