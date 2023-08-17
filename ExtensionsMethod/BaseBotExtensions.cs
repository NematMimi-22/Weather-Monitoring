using Weather_Monitoring.DataFormat;
using Weather_Monitoring.Bots;
namespace Weather_Monitoring.ExtensionsMethod
{
    public static class BaseBotExtensions
    {
        public static bool IsRainBotActivated(this RainBot rainBot, WeatherData weatherData)
        {
            return rainBot.IsActivated(weatherData);
        }

        public static bool IsSnowBotActivated(this SnowBot snowBot, WeatherData weatherData)
        {
            return snowBot.IsActivated(weatherData);
        }

        public static bool IsSunBotActivated(this SunBot sunBot, WeatherData weatherData)
        {
            return sunBot.IsActivated(weatherData);
        }
    }
}