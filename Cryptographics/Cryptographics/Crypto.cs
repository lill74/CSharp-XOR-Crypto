using System;
using System.Text;

namespace Crypto
{
    class Cipher
    {
        public byte[] Reversebytes(byte[] a)
        {
            byte[] rev = new byte[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                rev[a.Length - i - 1] = a[i];
            }

            return rev;
        }

        public byte[] Encrypt(byte[] a, string key)
        {
            byte[] skey = Encoding.UTF8.GetBytes(key);

            for (int j = 0; j < skey.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToByte(a[i] ^ skey[j]);
                }
            }
            return a;
        }

        public string Decrypt(byte[] a, string key)
        {
            byte[] skey = Reversebytes(Encoding.UTF8.GetBytes(key));

            for (int j = 0; j < skey.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToByte(a[i] ^ skey[j]);
                }
            }

            return Encoding.UTF8.GetString(a);
        }
    }
}
