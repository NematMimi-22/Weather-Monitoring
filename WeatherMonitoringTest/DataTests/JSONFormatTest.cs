using Weather_Monitoring.DataFormat;
using Xunit;

namespace Weather_Monitoring.WeatherMonitoringTest.DataTests
{
    public class JSONFormatTest
    {
        [Fact]
        public void FromJson_ValidJson_ReturnsWeatherData()
        {
            // Arrange
            var jsonInput = "{\"temperature\": 25.5, \"humidity\": 50.0}";

            // Act
            var weatherData = JSONParser.FromJson(jsonInput);

            // Assert
            Assert.NotNull(weatherData);
        }

        [Fact]
        public void FromJson_InvalidJson_ReturnsNull()
        {
            // Arrange
            var jsonInput = "{InvalidInput}";

                // Act
                var weatherData = JSONParser.FromJson(jsonInput);

            // Assert
            Assert.Null(weatherData);
        }

        [Fact]
        public void CreateReader_WithValidJSON_ReturnsWeatherData()
        {
            // Arrange
            string json = "{\"temperature\": 25, \"humidity\": 50}";

            // Act
            WeatherData weatherData = WeatherDataFactory.CreateReader(json);

            // Assert
            Assert.NotNull(weatherData);
        }
    }
}