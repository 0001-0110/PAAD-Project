using System.Security.Cryptography;
using System.Text;

namespace PAAD.BLL.Utilities
{
    public static class SecurityUtility
    {
        public static bool AreHashEqual(byte[] hash1, byte[] hash2)
        {
            if (hash1.Length != hash2.Length)
                return false;

            for (int i = 0; i < hash1.Length; i++) 
                if (hash1[i] != hash2[i])
                    return false;

            return true;
        }

        public static byte[] GetHash(string password, HashAlgorithm hashAlgorithm)
        {
            byte[] source = Encoding.ASCII.GetBytes(password);
            byte[] hash = hashAlgorithm.ComputeHash(source);
            return hash;
        }

        public static bool VerifyPassword(string password, byte[] hash, HashAlgorithm hashAlgorithm)
        {
            return AreHashEqual(GetHash(password, hashAlgorithm), hash);
        }
    }
}
