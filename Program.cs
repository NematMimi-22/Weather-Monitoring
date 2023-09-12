using Weather_Monitoring.DataFormat;
using Weather_Monitoring.Enums;
using Weather_Monitoring.Factory;
using Weather_Monitoring.PublishSubscribeDP;
using Weather_Monitoring.ReadConfig;
namespace Weather_Monitoring
{
    public class Program
    {
        // APPConfig
            // RainBotConfig
            // SunBotConfig
        public static void Main()
        {
            // TODO: didn't like reading config this way
            var rainBotConfig = ConfigReader.ReadAppConfig("RainBot");
            var sunBotConfig = ConfigReader.ReadConfig("SunBot");
            var snowBotConfig = ConfigReader.ReadConfig("SnowBot");
            var eventSubscriber = new WeatherPublisher();
            var botCreater = new BotFactory();

            var rainBot = botCreater.CreateBot(BotType.RainBot, rainBotConfig);
            var sunBot = botCreater.CreateBot(BotType.SunBot, sunBotConfig);
            var snowBot = botCreater.CreateBot(BotType.SnowBot, snowBotConfig);
            eventSubscriber.Subscribe(rainBot);
            eventSubscriber.Subscribe(sunBot);
            eventSubscriber.Subscribe(snowBot);

            while (true)
            {
                Console.WriteLine("Enter the weather data:");
                var input = Console.ReadLine();
                var weatherData = WeatherDataParser.ParseInput(input);
                var eventPublisher = new WeatherEventPublisher();
                eventPublisher.PublishEvent("HumidityExceeded", weatherData);
                eventPublisher.PublishEvent("TemperatureExceeded", weatherData);
                eventPublisher.PublishEvent("TemperatureDropped", weatherData);

                eventSubscriber.Unsubscribe( rainBot);
                eventSubscriber.Unsubscribe("TemperatureExceeded", sunBot);
                eventSubscriber.Unsubscribe("TemperatureExceeded", snowBot);
            }
        }
    }
}