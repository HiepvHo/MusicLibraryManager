using System;
using System.Security.Cryptography;
using System.Text;

namespace MusicLibraryManager.Helpers
{
    public static class SecurityHelper
    {
        /// <summary>
        /// Mã hóa password bằng SHA256
        /// </summary>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("X2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// So sánh password với hash
        /// </summary>
        public static bool VerifyPassword(string password, string hash)
        {
            string hashedPassword = HashPassword(password);
            return hashedPassword.Equals(hash, StringComparison.OrdinalIgnoreCase);
        }
    }
}

