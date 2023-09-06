using System.Xml.Serialization;
namespace Weather_Monitoring.DataFormat
{
    public class XmlParser
    {
        public static WeatherData FromXml(string xml)
        {
            var serializer = new XmlSerializer(typeof(WeatherData));

            using (TextReader reader = new StringReader(xml))
            {
                return (WeatherData)serializer.Deserialize(reader);
            }
        }
    }
}