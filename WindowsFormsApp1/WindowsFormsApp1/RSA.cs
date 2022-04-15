using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RSA
    {
        
        public string Encrypt( string text, string key)
        {
           
       
                CspParameters CSApars = new CspParameters();
                CSApars.KeyContainerName = key;
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(CSApars);
                

                byte[] byteText = Encoding.ASCII.GetBytes(text);
                byte[] byteEntry = rsa.Encrypt(byteText, false);
      
                return Convert.ToBase64String(byteEntry);
         
        }
       public string Decrypt(string text, string key)
        {
       
     
                CspParameters CSApars = new CspParameters();
                CSApars.KeyContainerName = key;

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(CSApars);
                 byte[] byteEntry = Convert.FromBase64String(text);
                 byte[] byteText = rsa.Decrypt(byteEntry, false);

            return Encoding.UTF8.GetString(byteText);

        }
    }
}
