using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
using Weather_Monitoring.ExtensionsMethod;

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

                if (WeatherBots.RainBot.enabled && WeatherBots.RainBot.IsRainBotActivated(weatherData))
                {
                    WeatherBots.RainBot.PerformAction();
                    Console.WriteLine($"RainBot:{WeatherBots.RainBot.message}");
                }

                if (WeatherBots.SnowBot.enabled && WeatherBots.SnowBot.IsSnowBotActivated(weatherData))
                {
                    WeatherBots.SnowBot.PerformAction();
                    Console.WriteLine($"SnowBot:{WeatherBots.SnowBot.message}");
                }

                if (WeatherBots.SunBot.enabled && WeatherBots.SunBot.IsSunBotActivated(weatherData))
                {
                    WeatherBots.SunBot.PerformAction();
                    Console.WriteLine($"SunBot:{WeatherBots.SunBot.message}");
                }
            }
        }
    }
}