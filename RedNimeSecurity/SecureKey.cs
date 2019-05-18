using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RedNimeSecurity
{
    class SecureKey
    {
        public static string Md5(string input)
        {
            StringBuilder Hash = new StringBuilder();
            MD5CryptoServiceProvider Md5Provider = new MD5CryptoServiceProvider();
            byte[] MyByte = Md5Provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int x = 0; x < MyByte.Length; x++)
            {
                Hash.Append(MyByte[x].ToString("x2"));
            }
            return Hash.ToString();
        }

        public static string Base64Encode(string input)
        {
            var PlainTextBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(PlainTextBytes);
        }

        public static string Base64Decode(string input)
        {
            var Base64 = Convert.FromBase64String(input);
            return Encoding.UTF8.GetString(Base64);
        }
    }
}
