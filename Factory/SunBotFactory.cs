using Weather_Monitoring.Bots;
namespace Weather_Monitoring.Factory
{
    public class SunBotFactory : IWeatherBotFactory
    {
        public IBaseBot CreateBot(WeatherBots weatherBots)
        {
            return new SunBot(weatherBots.SunBot.TemperatureThreshold, weatherBots.SunBot.enabled, weatherBots.SunBot.message);
        }
    }
}