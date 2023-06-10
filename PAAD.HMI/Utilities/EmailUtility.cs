using System.Text.RegularExpressions;

namespace PAAD.HMI.Utilities
{
    internal static class EmailUtility
    {
        private static Regex emailRegex = new Regex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$");

        public static bool IsValidEmail(string email) 
        {
            return emailRegex.IsMatch(email);
        }
    }
}
