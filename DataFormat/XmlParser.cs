using System.Xml.Serialization;
namespace Weather_Monitoring.DataFormat
{
    public class XmlParser
    {
        public static WeatherData FromXml(string xml)
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
    }
}