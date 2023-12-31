﻿using Weather_Monitoring.ReadConfig;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.ConfigFileTest
{
    public class ConfigReaderTests
    {
        [Theory]
        [InlineData("RainBot", 70)]
        public void ReadConfig_ReturnsValidBotConfig_WhenBotNameIsRainBot(string botName, int expectedThreshold)
        {
            // Act
            var botConfig = ConfigReader.ReadConfig(botName);

            // Assert
            Assert.Equal(expectedThreshold, botConfig.Threshold);
        }

        [Theory]
        [InlineData("SnowBot")]
        public void ReadConfig_ReturnsValidBotConfig_WhenBotNameIsSnowBot(string botName)
        {
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