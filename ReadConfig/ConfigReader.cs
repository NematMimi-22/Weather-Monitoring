using Microsoft.Extensions.Configuration;
namespace Weather_Monitoring.ReadConfig
{
    public class ConfigReader
    {
        public static BotConfig ReadConfig(string botName)
        {
            var basePath = "config.json";
            Console.WriteLine(basePath);
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
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
            if (botName == "SnowBot")
            {
                return int.Parse(configuration["SnowBot:TemperatureThreshold"]);
            }
            if (botName == "SunBot")
            {
                return int.Parse(configuration["SunBot:TemperatureThreshold"]);
            }
            return 0;
        }
    }
}