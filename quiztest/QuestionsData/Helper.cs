using System.Configuration;

namespace quiztest.QuestionsData
{
    static class Helper
    {
        public static string GetConString(string name) =>
            ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}
