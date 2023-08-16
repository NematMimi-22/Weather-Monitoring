using System.Text.Json;

namespace Weather_Monitoring.Bots
{
    public class ConfigReader
    {
        public static WeatherBots ReadConfig(string configFile)
        {
            string jsonContent = File.ReadAllText(configFile);
            WeatherBots WeatherBots = JsonSerializer.Deserialize<WeatherBots>(jsonContent);

            return JsonSerializer.Deserialize<WeatherBots>(jsonContent);
        }
    }
}