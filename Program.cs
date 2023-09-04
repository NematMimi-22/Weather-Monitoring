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
            eventSubscriber.Subscribe("HumidityExceeded", botCreater.CreateBot(BotType.RainBot, rainBotConfig));
            eventSubscriber.Subscribe("TemperatureExceeded", botCreater.CreateBot(BotType.SunBot, sunBotConfig));
            eventSubscriber.Subscribe("TemperatureExceeded", botCreater.CreateBot(BotType.SnowBot, snowBotConfig));

            while (true)
            {
                Console.WriteLine("Enter the weather data:");
                var input = Console.ReadLine();
                var weatherData = WeatherDataFactory.CreateReader(input);
                var eventPublisher = new WeatherEventPublisher();
                eventPublisher.PublishEvent("HumidityExceeded", weatherData);
                eventPublisher.PublishEvent("TemperatureExceeded", weatherData);
                eventPublisher.PublishEvent("TemperatureDropped", weatherData);
            }
        }
    }
}