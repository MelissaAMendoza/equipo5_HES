using System;
using System.Security.Cryptography;
using System.Text;

namespace SoftHES
{
    public class Control
    {
        public string ControlR(users usuario)
        {
            TransMySql trans = new TransMySql();
            string respuesta = " ";

            if(string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (usuario.Password == usuario.ConPassword)
                {
                    //Buscamos si es que ya existe algun usuario con esos datos

                    if (trans.existUs(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Password = generarSHA1(usuario.Password);
                        trans.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
                return respuesta;
            }
        }

        private string generarSHA1(string cadena)
        {

            UTF32Encoding enc = new UTF32Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

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
