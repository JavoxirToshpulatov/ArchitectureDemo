using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Security
{
    public class PasswordHasher
    {
        public const int SaltSize = 16;
        public const int HashSize = 16;
        public const int iterations = 1000;
        public static string GenerateSalt()
        {
            byte[] salt = new byte[SaltSize];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            return Convert.ToBase64String(salt);
        }

        public static string GenerateHash(string password,string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (var pbkdf2 = new Rfc2898DeriveBytes(passwordBytes, saltBytes, iterations))
            {
                byte[] hashBytes = pbkdf2.GetBytes(HashSize); ;

                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
