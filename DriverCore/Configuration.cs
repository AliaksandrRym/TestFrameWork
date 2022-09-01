
namespace TestFrameWork.DriverCore
{
    using System.Configuration;

    public class Configuration
    {
        private static string GetEnvironmentVariables(string var, string defaultValue)
            => ConfigurationManager.AppSettings[var] ?? defaultValue;

        public static string Browser => GetEnvironmentVariables("Browser", "Chrome");

        public static string StartUrl => GetEnvironmentVariables("Url", "https://www.globalsqa.com");
    }
}
