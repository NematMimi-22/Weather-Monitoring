using Weather_Monitoring.Bots;
namespace Weather_Monitoring.Factory
{
    public class RainBotFactory : IWeatherBotFactory
    {
        public IBaseBot CreateBot(WeatherBots weatherBots)
        {
            return new RainBot(weatherBots.RainBot.HumidityThreshold, weatherBots.RainBot.enabled, weatherBots.RainBot.message);
        }
    }
}