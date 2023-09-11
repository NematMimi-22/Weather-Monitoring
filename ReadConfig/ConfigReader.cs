using Microsoft.Extensions.Configuration;
namespace Weather_Monitoring.ReadConfig
{
    public class ConfigReader
    {
        public static BotConfig ReadConfig(string botName)
        {
            var configFilePath = @"C:\Users\Nemat\source\repos\Weather-Monitoring"; 

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(configFilePath) 
                .AddJsonFile("config.json", optional: false, reloadOnChange: true)
                .Build();

            var Threshold = GetThreshold(botName, configuration);
            var Message = configuration[$"{botName}:Message"];
            var Enabled = bool.Parse(configuration[$"{botName}:Enabled"]);

            return new BotConfig(Enabled, Threshold, Message); 
        }

        private static int GetThreshold(string botName, IConfiguration configuration)
        {
            if (botName == "RainBot")
            {
                return int.Parse(configuration["RainBot:HumidityThreshold"]);
            }
            else if (botName == "SnowBot")
            {
                return int.Parse(configuration["SnowBot:TemperatureThreshold"]);
            }
            else if (botName == "SunBot")
            {
                return int.Parse(configuration["SunBot:TemperatureThreshold"]);
            }
            return 0;
        }
    }
}