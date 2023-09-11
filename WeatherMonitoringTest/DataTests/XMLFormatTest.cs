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
            // Act
            var weatherData = XmlParser.FromXml(xmlInput);

            // Assert
            Assert.NotNull(weatherData);
        }

        [Theory]
        [InlineData("test")]
        public void FromXML_InvalidXML_ReturnsNull(string xmlInput)
        {
            // Act
            var weatherData = XmlParser.FromXml(xmlInput);

            // Assert
            Assert.Null(weatherData);
        }

        [Theory]
        [InlineData("<WeatherData><Location>City Name</Location><Temperature>23.0</Temperature><Humidity>85.0</Humidity></WeatherData>\r\n")]
        public void CreateReader_WithValidXML_ReturnsWeatherData(string xmlInput)
        {
            // Act
            WeatherData weatherData = WeatherDataFactory.CreateReader(xmlInput);

            // Assert
            Assert.NotNull(weatherData);
        }
    }
}