using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class PublicKeyEncryption
    {

        static void Main(string[] args)
        {

            string publicKey;
            string privateKey;

            string msg = "o rato roeu a rolha do rei da russia"; //normalmente chaves simetricas 
           
            Rsa rsa = new Rsa();

            string cipher = rsa.Encrypt(msg, out publicKey, out privateKey);

            string decMsg = rsa.Decrypt(cipher, privateKey);

            Console.WriteLine("Mensagem: {0}\nCifra: {1}\nDecifra: {2}", msg, cipher, decMsg);



        }
    }
}
