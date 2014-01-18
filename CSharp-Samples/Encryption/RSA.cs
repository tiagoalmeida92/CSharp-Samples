using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Rsa 
    {
        /// <summary>
        ///     http://stackoverflow.com/questions/3152698/cryptographicexception-intermittently-occurs-when-encrypting-decrypting-with-rsa
        /// </summary>
        //static UnicodeEncoding _encoding = new UnicodeEncoding();

        public string Encrypt(string msg, out string publicKey, out string privateKey)
        {
            byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(msg);
            using (var rsa = new RSACryptoServiceProvider())
            {
                byte[] cipher = rsa.Encrypt(bytesToEncrypt, false);
                publicKey = rsa.ToXmlString(false);
                privateKey = rsa.ToXmlString(true);

                return Convert.ToBase64String(cipher);
            }
        }


        public string Decrypt(string cipher, string privateKey)
        {

            using (var rsa = new RSACryptoServiceProvider())
            {
                byte[] bytesToDecrypt = Convert.FromBase64String(cipher);
                rsa.FromXmlString(privateKey);
                byte[] decryptedBytes = rsa.Decrypt(bytesToDecrypt, false);

                return Encoding.UTF8.GetString(decryptedBytes);
            }


            
            
         }  
         
    }
}
