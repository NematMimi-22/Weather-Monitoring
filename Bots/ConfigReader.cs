using System.Text.Json;
namespace Weather_Monitoring.Bots
{
    public class ConfigReader
    {
        public static WeatherBots ReadConfig(string configFile)
        {
            var jsonContent = File.ReadAllText(configFile);
            var WeatherBots = JsonSerializer.Deserialize<WeatherBots>(jsonContent);

            return JsonSerializer.Deserialize<WeatherBots>(jsonContent);
        }
    }
}