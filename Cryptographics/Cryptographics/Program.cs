using System.Text;
using Crypto;
// Simple XOR Encryption system.

namespace Cryptographics
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher Enc = new Cipher();

            string data = "I LOVE Cryptographics";
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] bts = Enc.Encrypt(bytes, "pass");
            Enc.Decrypt(bts, "pass");
        }


    }
}
