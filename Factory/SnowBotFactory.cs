using Weather_Monitoring.Bots;
namespace Weather_Monitoring.Factory
{
    public class SnowBotFactory : IWeatherBotFactory
    {
        public IBaseBot CreateBot(WeatherBots weatherBots)
        {
            return new SnowBot(weatherBots.SnowBot.TemperatureThreshold, weatherBots.SnowBot.enabled, weatherBots.SnowBot.message);
        }
    }
}