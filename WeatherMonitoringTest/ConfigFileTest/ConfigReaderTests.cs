using Weather_Monitoring.ReadConfig;
using Xunit;
using Microsoft.Extensions.Configuration;
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

        [Fact]
        public void ReadConfig_ReturnsValidBotConfig_WhenBotNameIsSunBot()
        {
            // Arrange
            var botName = "SunBot";

            // Act
            var botConfig = ConfigReader.ReadConfig(botName);

            // Assert
            Assert.True(botConfig.Enabled);
        }
    }
}