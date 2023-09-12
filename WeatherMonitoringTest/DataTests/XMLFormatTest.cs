using Weather_Monitoring.DataFormat;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.DataTests
{
    public class XMLFormatTest
    {
        [Theory]
        [InlineData("<WeatherData><Location>City Name</Location><Temperature>23.0</Temperature><Humidity>85.0</Humidity></WeatherData>\r\n")]
        public void FromXML_ValidXML_ReturnsWeatherData(string xmlInput)
        {
            // Arrange
            var parser = new XmlParser();

            // Act
            var weatherData = parser.Parse(xmlInput);

            // Assert
            Assert.NotNull(weatherData);
        }

        [Theory]
        [InlineData("test")]
        public void FromXML_InvalidXML_ReturnsNull(string xmlInput)
        {
            // Arrange
            var parser = new XmlParser();

            // Act
            var weatherData = parser.Parse(xmlInput);

            // Assert
            Assert.Null(weatherData);
        }

        [Theory]
        [InlineData("<WeatherData><Location>City Name</Location><Temperature>23.0</Temperature><Humidity>85.0</Humidity></WeatherData>\r\n")]
        public void CreateReader_WithValidXML_ReturnsWeatherData(string xmlInput)
        {
            // Arrange
            var parser = new List<IWetherDataParser>
                {
                    new XmlParser(),
                };
            var weatherDataParser = new WeatherDataParser(parser);

            // Act
            var weatherData = weatherDataParser.ParseInput(xmlInput);

            // Assert
            Assert.NotNull(weatherData);
        }
    }
}