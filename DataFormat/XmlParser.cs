using System.Text.RegularExpressions;
using System.Xml.Serialization;
namespace Weather_Monitoring.DataFormat
{
    public class XmlParser : IWetherDataParser
    {
        public WeatherData Parse(string xml)
        {
            var serializer = new XmlSerializer(typeof(WeatherData));
            try
            {
                using (TextReader reader = new StringReader(xml))
                {
                    return (WeatherData)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool IsSupportedFormat(string inputFormat)
        {
            return Regex.IsMatch(inputFormat.Trim(), @"^<.*>$");
        }
    }
}