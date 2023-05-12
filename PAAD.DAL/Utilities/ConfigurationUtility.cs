using System.Configuration;

namespace PAAD.DAL.Utilities
{
    internal static class ConfigurationUtility
    {
        public static string GetConnectionString()
        {
            // TODO Hard coded string
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["AufgepasstConnectionString"];
            return connectionStringSettings.ConnectionString;
        }
    }
}
