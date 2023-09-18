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
            // Arrange
            var parser =new JSONParser();

            // Act
            var weatherData = parser.Parse(jsonInput);

            // Assert
            Assert.NotNull(weatherData);
        }

        [Theory]
        [InlineData("Invalid")]
        public void FromJson_InvalidJson_ReturnsNull(string jsonInput)
        {
            // Arrange
            var parser = new JSONParser();

            // Act
            var weatherData = parser.Parse(jsonInput);

            // Assert
            Assert.Null(weatherData);
        }

        [Theory]
        [InlineData("{\"temperature\": 25.5, \"humidity\": 50.0}")]
        [InlineData(" {\"Location\": \"City Name\", \"Temperature\": 23.0, \"Humidity\": 85.0}")]
        public void CreateReader_WithValidJSON_ReturnsWeatherData(string json)
        {
            // Arrange
            var parser = new List<IWetherDataParser>
                {
                    new JSONParser(),
                };
            var weatherDataParser = new WeatherDataParser(parser);

            // Act
            var weatherData = weatherDataParser.ParseInput(json);

            // Assert
            Assert.NotNull(weatherData);
        }
    }
}