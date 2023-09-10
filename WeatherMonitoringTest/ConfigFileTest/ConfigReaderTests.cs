using Weather_Monitoring.ReadConfig;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.ConfigFileTest
{
    public class ConfigReaderTests
    {
        [Fact]
        public void ReadConfig_ReturnsValidBotConfig_WhenBotNameIsRainBot()
        {
            // Arrange
            var botName = "RainBot";

            // Act
            var botConfig = ConfigReader.ReadConfig(botName);

            // Assert
            Assert.Equal(70, botConfig.Threshold);
        }

        [Fact]
        public void ReadConfig_ReturnsValidBotConfig_WhenBotNameIsSnowBot()
        {
            // Arrange
            var botName = "SnowBot";

            // Act
            var botConfig = ConfigReader.ReadConfig(botName);

            // Assert
            Assert.False(botConfig.Enabled);
        }

        [Theory]
        [InlineData("RainBot")]
        [InlineData("SunBot")]
        public void ReadConfig_ReturnsValidBotConfig_WhenBotNameIsSunBot(string botName)
        {
            // Act
            var botConfig = ConfigReader.ReadConfig(botName);

            // Assert
            Assert.True(botConfig.Enabled);
        }
    }
}