using Weather_Monitoring.Bots;
using Weather_Monitoring.Enums;
using Weather_Monitoring.Factory;
using Weather_Monitoring.ReadConfig;
using Xunit;

namespace Weather_Monitoring.WeatherMonitoringTest.BotTests
{
    public class BotFactoryTests
    {
        [Fact]
        public void CreateBot_ReturnsRainBot_WhenBotTypeIsRainBot()
        {
            // Arrange
            var factory = new BotFactory();
            var botConfig = new BotConfig(true, 30, "Rain is expected.");

            // Act
            var bot = factory.CreateBot(BotType.RainBot, botConfig);

            // Assert
            Assert.IsType<RainBot>(bot);
        }

        [Fact]
        public void CreateBot_ReturnsSnowBot_WhenBotTypeIsSnowBot()
        {
            // Arrange
            var factory = new BotFactory();
            var botConfig = new BotConfig(true, 30, "Snow is expected.");

            // Act
            var bot = factory.CreateBot(BotType.SnowBot, botConfig);

            // Assert
            Assert.IsType<SnowBot>(bot);
        }

        [Fact]
        public void CreateBot_ReturnsSunBot_WhenBotTypeIsSunBot()
        {
            // Arrange
            var factory = new BotFactory();
            var botConfig = new BotConfig(true, 30, "Sun is expected.");

            // Act
            var bot = factory.CreateBot(BotType.SunBot, botConfig);

            // Assert
            Assert.IsType<SunBot>(bot);
        }

        [Fact]
        public void CreateBot_ReturnsNull_WhenBotTypeIsInvalid()
        {
            // Arrange
            var factory = new BotFactory();
            var botConfig = new BotConfig(true, 30, "Invalid");

            // Act
            var bot = factory.CreateBot((BotType)3, botConfig);

            // Assert
            Assert.Null(bot);
        }
    }
}