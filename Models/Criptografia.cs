using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Biblioteca.Models
{
    public class Criptografia
    {
        public static string GerarMD5(string textoincial){

            MD5 MD5hasher = MD5.Create();
            byte[] bytesOriginais = Encoding.Default.GetBytes(textoincial);
            byte[] bytesCriptografados = MD5hasher.ComputeHash(bytesOriginais);

            StringBuilder textoCriptografado = new StringBuilder();

            foreach(byte b in bytesCriptografados){

                string Debug = b.ToString("x2");
                textoCriptografado.Append(Debug);

            }


            return textoCriptografado.ToString();
        }
    }
}