using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography; // NameSpace para trabalhar com Criptografia

namespace Apresentacao_Usuario
{
    public class Criptografia
    {
        // Variáveis para Criptografia
        Byte[] IV = new Byte[] { 0x0012, 0x0034, 0x0056, 0x0078, 0x0090, 0x00AB, 0x00CD, 0x00EF, 0x0013, 0x0045, 0x0099, 0x00AA, 0x0012 };
        Byte[] key = System.Text.Encoding.UTF8.GetBytes("12345678");

        public String Encrypit (String strValor)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                Byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(strValor);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray ());
            }
            catch (System .Exception ex)
            {
                return ex.Message;
            }
        }
        public String Decrypt (String strValor)
        {
            Byte[] inputByteArray = new Byte[strValor.Length];
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strValor);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
                
            }
            catch  (System .Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
