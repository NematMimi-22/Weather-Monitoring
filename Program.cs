using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
using Weather_Monitoring.Enums;
namespace Weather_Monitoring
{
    public class Program
    {
        public static void Main()
        {
            var jsonFilePath = @"C:\Users\Nemat\source\repos\Weather-Monitoring\config.json";
            var WeatherBots = ConfigReader.ReadConfig(jsonFilePath);
            var basebotFactory = new BaseBotFactory();

            while (true)
            {
                Console.WriteLine("Enter the weather data:");
                var input = Console.ReadLine();
                var weatherData = WeatherDataFactory.CreateReader(input);
                if (WeatherBots.RainBot.enabled && WeatherBots.RainBot.IsActivated(weatherData))
                {
                    var Rainbot = basebotFactory.GetBot(BotType.RainBot, WeatherBots);
                    Rainbot.PerformAction();
                    Console.WriteLine($"{Rainbot.Name}:{Rainbot.message}");
                }

                if (WeatherBots.SnowBot.enabled && WeatherBots.SnowBot.IsActivated(weatherData))
                {
                    var Snowbot = basebotFactory.GetBot(BotType.SnowBot, WeatherBots);
                    Snowbot.PerformAction();
                    Console.WriteLine($"{Snowbot.Name}:{Snowbot.message}");
                }

                if (WeatherBots.SunBot.enabled && WeatherBots.SunBot.IsActivated(weatherData))
                {
                    var Sunbot = basebotFactory.GetBot(BotType.SunBot, WeatherBots);
                    Sunbot.PerformAction();
                    Console.WriteLine($"{Sunbot.Name}:{Sunbot.message}");
                }
            }
        }
    }
}