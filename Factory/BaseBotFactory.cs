using Weather_Monitoring.Bots;
using Weather_Monitoring.Enums;
namespace Weather_Monitoring.Factory
{
    public class BaseBotFactory
    {
        private readonly Dictionary<BotType, IWeatherBotFactory> factories;

        public BaseBotFactory()
        {
            factories = new Dictionary<BotType, IWeatherBotFactory>
        {
            { BotType.RainBot, new RainBotFactory() },
            { BotType.SnowBot, new SnowBotFactory() },
            { BotType.SunBot, new SunBotFactory() }
        };
        }

        public IBaseBot GetBot(BotType botType, WeatherBots weatherBots)
        {
            if (factories.TryGetValue(botType, out var factory))
            {
                return factory.CreateBot(weatherBots);
            }

            return null;
        }
    }
}