using Weather_Monitoring.DataFormat;
using Weather_Monitoring.Bots;
namespace Weather_Monitoring.ExtensionsMethod
{
    public static class BaseBotExtensions
    {
        public static bool IsActivated(this BaseBot bot, WeatherData weatherData)
        {
            return bot.IsActivated(weatherData);
        }
    }
}