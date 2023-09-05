﻿using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.BotTests
{
    public class BotTests
    {
        [Fact]
        public void RainBot_WhenHumidityAboveThreshold_ShouldReturnTrue()
        {
            // Arrange
            var weatherData = new WeatherData { Humidity = 80 };
            var rainBot = new RainBot(70, true, "Rain is expected");

            // Act
            var result= rainBot.PerformAction(weatherData);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void RainBot_WhenHumidityLessThanThreshold_ShouldReturnFalse()
        {
            // Arrange
            var weatherData = new WeatherData { Humidity = 50 };
            var rainBot = new RainBot(70, true, "Rain is expected");

            // Act
            var result = rainBot.PerformAction(weatherData);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SunBot_WhenTemperatureThresholdAboveTemperature_ShouldReturnTrue()
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = 80 };
            var sunBot = new SunBot(70, true, "Sun is expected");

            // Act
            var result = sunBot.PerformAction(weatherData);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SunBot_WhenTemperatureThresholdLessThanTemperature_ShouldReturnFalse()
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = 80 };
            var sunBot = new SunBot(90, true, "Sun is expected");

            // Act
            var result = sunBot.PerformAction(weatherData);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SnowBot_WhenTemperatureThresholdAboveTemperature_ShouldReturnFalse()
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = 80 };
            var SnowBot = new SnowBot(70, true, "Snow is expected");

            // Act
            var result = SnowBot.PerformAction(weatherData);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SnowBot_WhenTemperatureThresholdLessThanTemperature_ShouldReturnTrue()
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = 80 };
            var SnowBot = new SnowBot(90, true, "Snow is expected");

            // Act
            var result = SnowBot.PerformAction(weatherData);

            //Assert
            Assert.True(result);
        }


    }
}