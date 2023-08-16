using System.Text.Json;
using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring
{
    public class Program
    {
        public static void Main()
        {
            var jsonFilePath = @"C:\Users\Nemat\source\repos\Weather-Monitoring\config.json";
            var WeatherBots = ConfigReader.ReadConfig(jsonFilePath);

            while (true)
            {
                Console.WriteLine("Enter the weather data:");
                var input = Console.ReadLine();
                var weatherData = WeatherDataFactory.CreateReader(input);
                if (WeatherBots.RainBot.enabled=true && WeatherBots.RainBot.IsActivated(weatherData))
                {
                    WeatherBots.RainBot.PerformAction();
                    Console.WriteLine($"RainBot:{WeatherBots.RainBot.message}");
                }
                if (WeatherBots.SnowBot.enabled = true && WeatherBots.SnowBot.IsActivated(weatherData))
                {
                    WeatherBots.SnowBot.PerformAction();
                    Console.WriteLine($"SnowBot:{WeatherBots.SnowBot.message}");
                }
                if (WeatherBots.SunBot.enabled = true && WeatherBots.SunBot.IsActivated(weatherData))
                {
                    WeatherBots.SunBot.PerformAction();
                    Console.WriteLine($"SunBot:{WeatherBots.SunBot.message}");
                }
            }
        }
    }
}