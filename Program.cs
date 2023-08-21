using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
using Weather_Monitoring.Enums;
using Weather_Monitoring.PrinterService;
namespace Weather_Monitoring
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the path to the JSON config file: ");
            var jsonFilePath = Console.ReadLine();
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
                    BotMessagePrinter.PrintBotMessage(Rainbot);
                }

                if (WeatherBots.SnowBot.enabled && WeatherBots.SnowBot.IsActivated(weatherData))
                {
                    var Snowbot = basebotFactory.GetBot(BotType.SnowBot, WeatherBots);
                    Snowbot.PerformAction();
                    BotMessagePrinter.PrintBotMessage(Snowbot);
                }

                if (WeatherBots.SunBot.enabled && WeatherBots.SunBot.IsActivated(weatherData))
                {
                    var Sunbot = basebotFactory.GetBot(BotType.SunBot, WeatherBots);
                    Sunbot.PerformAction();
                    BotMessagePrinter.PrintBotMessage(Sunbot);
                }
            }
        }
    }
}