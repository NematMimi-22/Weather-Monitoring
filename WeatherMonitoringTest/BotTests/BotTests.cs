using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.BotTests
{
    public class BotTests
    {
        [Theory]
        [InlineData(80, 70, true, "Rain is expected")]
        [InlineData(100, 70, true, "Rain is expected")]
        public void RainBot_WhenHumidityAboveThreshold_ShouldReturnTrue(int humidity,int Threshold, bool enabled,string message)
        {
            // Arrange
            var weatherData = new WeatherData { Humidity = humidity };
            var rainBot = new RainBot(Threshold, enabled, message);

            // Act
            var result= rainBot.PerformAction(weatherData);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(50, 70, false, "Rain is expected")]
        [InlineData(40, 70, true, "Rain is expected")]
        public void RainBot_WhenHumidityLessThanThreshold_ShouldReturnFalse(int humidity, int Threshold, bool enabled, string message)
        {
            // Arrange
            var weatherData = new WeatherData { Humidity = humidity };
            var rainBot = new RainBot(Threshold, enabled, message);

            // Act
            var result = rainBot.PerformAction(weatherData);

            //Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(80, 70, true, "sun is expected")]
        public void SunBot_WhenTemperatureThresholdAboveTemperature_ShouldReturnTrue(int temperature, int Threshold, bool enabled, string message)
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = temperature };
            var sunBot = new SunBot(Threshold, enabled, message);

            // Act
            var result = sunBot.PerformAction(weatherData);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(100, 90, false, "sun is expected")]
        [InlineData(80, 90, true, "sun is expected")]
        public void SunBot_WhenTemperatureThresholdLessThanTemperature_ShouldReturnFalse(int temperature, int Threshold, bool enabled, string message)
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = temperature };
            var sunBot = new SunBot(Threshold, enabled, message);

            // Act
            var result = sunBot.PerformAction(weatherData);

            //Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(80, 20, true, "Snow is expected")]
        [InlineData(80, 20, false, "Snow is expected")]
        public void SnowBot_WhenTemperatureThresholdAboveTemperature_ShouldReturnFalse(int temperature, int Threshold, bool enabled, string message)
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = temperature };
            var SnowBot = new SnowBot(Threshold, enabled, message);

            // Act
            var result = SnowBot.PerformAction(weatherData);

            //Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(80, 100, true, "Snow is expected")]
        public void SnowBot_WhenTemperatureThresholdLessThanTemperature_ShouldReturnTrue(int temperature, int Threshold, bool enabled, string message)
        {
            // Arrange
            var weatherData = new WeatherData { Temperature = temperature };
            var SnowBot = new SnowBot(Threshold, enabled, message);

            // Act
            var result = SnowBot.PerformAction(weatherData);

            //Assert
            Assert.True(result);
        }
    }
}