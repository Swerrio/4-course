using System;
using System.Security.Cryptography;

namespace CarRental
{
    // Хранение паролей. Пароль никогда не сохраняется в открытом виде:
    // в базу пишется результат PBKDF2 вместе со случайной солью.
    // Формат строки: pbkdf2$<итерации>$<соль base64>$<хеш base64>
    public static class PasswordHasher
    {
        private const int Iterations = 20000;
        private const int SaltSize = 16;
        private const int KeySize = 32;

        public static string Hash(string password)
        {
            byte[] salt = new byte[SaltSize];
            using (RNGCryptoServiceProvider rng =
                new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            byte[] key = Derive(password, salt);
            return "pbkdf2$" + Iterations + "$" +
                Convert.ToBase64String(salt) + "$" +
                Convert.ToBase64String(key);
        }

        public static bool Verify(string password, string stored)
        {
            if (string.IsNullOrEmpty(stored))
            {
                return false;
            }

            string[] parts = stored.Split('$');
            if (parts.Length != 4 || parts[0] != "pbkdf2")
            {
                return false;
            }

            try
            {
                int iterations = int.Parse(parts[1]);
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] expected = Convert.FromBase64String(parts[3]);
                byte[] actual = Derive(password, salt, iterations,
                    expected.Length);
                return Equal(expected, actual);
            }
            catch
            {
                return false;
            }
        }

        private static byte[] Derive(string password, byte[] salt)
        {
            return Derive(password, salt, Iterations, KeySize);
        }

        private static byte[] Derive(string password, byte[] salt,
            int iterations, int size)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(
                password, salt, iterations, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(size);
            }
        }

        // Сравнение за постоянное время, чтобы по скорости ответа нельзя
        // было подбирать хеш по байтам
        private static bool Equal(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }
    }
}
