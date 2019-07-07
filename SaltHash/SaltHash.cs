using System;
using System.Security.Cryptography;
using System.Text;

namespace SaltHash
{
    public class SaltHash : ISaltHash
    {
        public string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();

            var buff = new byte[size];

            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

        public string GenerateHash(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);

            var sha512HashString = new SHA512Managed();

            byte[] hash = sha512HashString.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }
    }
}
