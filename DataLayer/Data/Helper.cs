using System.Configuration;

namespace DataLayer.Data
{
    static class Helper
    {
        public static string GetConString(string name) =>
            ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}
