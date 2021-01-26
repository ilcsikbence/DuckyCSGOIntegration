namespace DuckyCSGOIntegration.Configuration
{
    public static class ConfigurationManager
    {
        public static Configuration Configuration = ConfigurationManager.Initialize();

        public static Configuration Initialize()
        {
            return new Configuration();
        }
    }
}
