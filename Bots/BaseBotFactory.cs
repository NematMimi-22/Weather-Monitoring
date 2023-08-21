using Weather_Monitoring.Enums;
namespace Weather_Monitoring.Bots
{
    public class BaseBotFactory
    {
        public IBaseBot GetBot(BotType botType, WeatherBots weatherBots)
        {
            switch (botType)
            {
                case BotType.RainBot:
                    return new RainBot(weatherBots.RainBot.HumidityThreshold, weatherBots.RainBot.enabled, weatherBots.RainBot.message);
                case BotType.SnowBot:
                    return new SnowBot(weatherBots.SnowBot.TemperatureThreshold, weatherBots.SnowBot.enabled, weatherBots.SnowBot.message);
                case BotType.SunBot:
                    return new SunBot(weatherBots.SunBot.TemperatureThreshold, weatherBots.SunBot.enabled, weatherBots.SunBot.message);
                default:
                    return null;
            }
        }
    }
}