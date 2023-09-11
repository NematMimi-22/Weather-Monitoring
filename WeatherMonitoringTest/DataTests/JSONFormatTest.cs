using Weather_Monitoring.DataFormat;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.DataTests
{
    public class JSONFormatTest
    {
        [Theory]
        [InlineData("{\"temperature\": 25.5, \"humidity\": 50.0}")]
        [InlineData(" {\"Location\": \"City Name\", \"Temperature\": 23.0, \"Humidity\": 85.0}")]
        public void FromJson_ValidJson_ReturnsWeatherData(string jsonInput)
        {
            // Act
            var weatherData = JSONParser.FromJson(jsonInput);

            // Assert
            Assert.NotNull(weatherData);
        }

        [Theory]
        [InlineData("Invalid")]
        public void FromJson_InvalidJson_ReturnsNull(string jsonInput)
        {
            // Act
            var weatherData = JSONParser.FromJson(jsonInput);

            // Assert
            Assert.Null(weatherData);
        }

        [Theory]
        [InlineData("{\"temperature\": 25.5, \"humidity\": 50.0}")]
        [InlineData(" {\"Location\": \"City Name\", \"Temperature\": 23.0, \"Humidity\": 85.0}")]
        public void CreateReader_WithValidJSON_ReturnsWeatherData(string json)
        {
            // Act
            WeatherData weatherData = WeatherDataFactory.CreateReader(json);

            // Assert
            Assert.NotNull(weatherData);
        }
    }
}