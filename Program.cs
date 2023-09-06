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
            var botCreater = new BotFactory();

            var rainBot = botCreater.CreateBot(BotType.RainBot, rainBotConfig);
            var sunBot = botCreater.CreateBot(BotType.SunBot, sunBotConfig);
            var snowBot = botCreater.CreateBot(BotType.SnowBot, snowBotConfig);
            eventSubscriber.Subscribe("HumidityExceeded", rainBot);
            eventSubscriber.Subscribe("TemperatureExceeded", sunBot);
            eventSubscriber.Subscribe("TemperatureExceeded", snowBot);

            while (true)
            {
                Console.WriteLine("Enter the weather data:");
                var input = Console.ReadLine();
                var weatherData = WeatherDataFactory.CreateReader(input);
                var eventPublisher = new WeatherEventPublisher();
                eventPublisher.PublishEvent("HumidityExceeded", weatherData);
                eventPublisher.PublishEvent("TemperatureExceeded", weatherData);
                eventPublisher.PublishEvent("TemperatureDropped", weatherData);

                eventSubscriber.Unsubscribe("HumidityExceeded", rainBot);
                eventSubscriber.Unsubscribe("TemperatureExceeded", sunBot);
                eventSubscriber.Unsubscribe("TemperatureExceeded", snowBot);


            }
        }
    }
}