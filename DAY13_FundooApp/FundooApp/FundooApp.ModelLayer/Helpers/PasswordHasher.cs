using System.Security.Cryptography;

namespace FundooApp.ModelLayer.Helpers
{
    public static class PasswordHasher
    {
        public static (string Hash, string Salt) HashPassword(string password)
        {
            using var hmac = new HMACSHA512();

            byte[] salt = hmac.Key;

            byte[] hash = hmac.ComputeHash(
                System.Text.Encoding.UTF8.GetBytes(password));

            return (
                Convert.ToBase64String(hash),
                Convert.ToBase64String(salt)
            );
        }

        public static bool VerifyPassword(
            string password,
            string storedHash,
            string storedSalt)
        {
            byte[] salt = Convert.FromBase64String(storedSalt);

            byte[] storedHashBytes =
                Convert.FromBase64String(storedHash);

            using var hmac = new HMACSHA512(salt);

            byte[] computedHash =
                hmac.ComputeHash(
                    System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(storedHashBytes);
        }
    }
}