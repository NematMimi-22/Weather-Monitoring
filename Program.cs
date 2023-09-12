using Weather_Monitoring.DataFormat;
using Weather_Monitoring.Enums;
using Weather_Monitoring.Factory;
using Weather_Monitoring.PublishSubscribeDP;
using Weather_Monitoring.ReadConfig;
namespace Weather_Monitoring
{
    public class Program
    {
        public static void Main()
        {
            var rainBotConfig = ConfigReader.ReadConfig("RainBot");
            var sunBotConfig = ConfigReader.ReadConfig("SunBot");
            var snowBotConfig = ConfigReader.ReadConfig("SnowBot");
            var eventSubscriber = new WeatherEventSubscriber();
            var botCreator = new BotFactory();

            var rainBot = botCreator.CreateBot(BotType.RainBot, rainBotConfig);
            var sunBot = botCreator.CreateBot(BotType.SunBot, sunBotConfig);
            var snowBot = botCreator.CreateBot(BotType.SnowBot, snowBotConfig);
            eventSubscriber.Subscribe(rainBot);
            eventSubscriber.Subscribe(sunBot);
            eventSubscriber.Subscribe(snowBot);

            while (true)
            {
                Console.WriteLine("Enter the weather data:");
                var input = Console.ReadLine();
                var parsers = new List<IWetherDataParser>
                {
                    new JSONParser(),
                    new XmlParser(),
                };
                var weatherDataParser = new WeatherDataParser(parsers);
                try
                {
                    var weatherData = weatherDataParser.ParseInput(input);
                    if (weatherData != null)
                    {
                        var eventPublisher = new WeatherEventPublisher();
                        eventPublisher.Publish(weatherData);
                        eventSubscriber.Unsubscribe(rainBot);
                        eventSubscriber.Unsubscribe(sunBot);
                        eventSubscriber.Unsubscribe(snowBot);
                    }
                    else
                    {
                        Console.WriteLine("Failed to parse weather data. Unsupported format.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}