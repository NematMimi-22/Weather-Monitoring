using Weather_Monitoring.Bots;
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
    }
}
