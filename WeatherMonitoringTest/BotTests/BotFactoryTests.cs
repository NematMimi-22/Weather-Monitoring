using Weather_Monitoring.Bots;
using Weather_Monitoring.Enums;
using Weather_Monitoring.Factory;
using Weather_Monitoring.ReadConfig;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.BotTests
{
    public class BotFactoryTests
    {
        [Theory]
        [InlineData(BotType.RainBot, true, 40, "Rain is expected", typeof(RainBot))]
        [InlineData(BotType.SunBot, true, 30, "Sun is expected", typeof(SunBot))]
        [InlineData(BotType.SnowBot, true, 10, "Snow is expected", typeof(SnowBot))]
        public void CreateBot_ReturnsRainBot_WhenBotTypeIsRainBot(BotType bottype, bool enabled, int Threshold, string message, Type expectedType)
        {
            // Arrange
            var factory = new BotFactory();
            var botConfig = new BotConfig(enabled, Threshold, message);

            // Act
            var bot = factory.CreateBot(bottype, botConfig);

            // Assert
            Assert.IsType(expectedType, bot);
        }

        [Theory]
        [InlineData((BotType)3, true, 10, "Invalid")]
        public void CreateBot_ReturnsNull_WhenBotTypeIsInvalid(BotType bottype, bool enabled, int Threshold, string message)
        {
            // Arrange
            var factory = new BotFactory();
            var botConfig = new BotConfig(enabled, Threshold, message);

            // Act
            var bot = factory.CreateBot(bottype, botConfig);

            // Assert
            Assert.Null(bot);
        }
    }
}