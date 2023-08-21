using Weather_Monitoring.Bots;
namespace Weather_Monitoring.Factory
{
    public interface IWeatherBotFactory
    {
        IBaseBot CreateBot(WeatherBots weatherBots);
    }
}