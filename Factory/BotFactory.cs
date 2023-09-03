using Weather_Monitoring.Bots;
using Weather_Monitoring.Enums;
using Weather_Monitoring.ReadConfig;

namespace Weather_Monitoring.Factory
{
    public class BotFactory
    {
        public IBot CreateBot(BotType botType, BotConfig botConfig)
        {
            switch (botType)
            {
                case BotType.RainBot:
                    return new RainBot(botConfig.Threshold, botConfig.Enabled, botConfig.Message);
                case BotType.SnowBot:
                    return new SnowBot(botConfig.Threshold, botConfig.Enabled, botConfig.Message);
                case BotType.SunBot:
                    return new SunBot(botConfig.Threshold, botConfig.Enabled, botConfig.Message);
                default:
                    return null;
            }
        }

    }
}