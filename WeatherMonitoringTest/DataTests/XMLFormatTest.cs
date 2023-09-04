using Weather_Monitoring.DataFormat;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.DataTests
{
    public class XMLFormatTest
    {
        [Fact]
        public void FromXML_ValidXML_ReturnsWeatherData()
        {
            // Arrange
            var xmlInput = "<WeatherData><Location>City Name</Location><Temperature>23.0</Temperature><Humidity>85.0</Humidity></WeatherData>\r\n";

            // Act
            var weatherData = XmlParser.FromXml(xmlInput);

            // Assert
            Assert.NotNull(weatherData);
        }

        [Fact]
        public void FromXML_InvalidXML_ReturnsNull()
        {
            // Arrange
            var xmlInput = "test";

            // Act
            var weatherData = XmlParser.FromXml(xmlInput);

            // Assert
            Assert.Null(weatherData);
        }

        [Fact]
        public void CreateReader_WithValidXML_ReturnsWeatherData()
        {
            // Arrange
            var xmlInput = "<WeatherData><Location>City Name</Location><Temperature>23.0</Temperature><Humidity>85.0</Humidity></WeatherData>\r\n";

            // Act
            WeatherData weatherData = WeatherDataFactory.CreateReader(xmlInput);

            // Assert
            Assert.NotNull(weatherData);
        }
    }
}
