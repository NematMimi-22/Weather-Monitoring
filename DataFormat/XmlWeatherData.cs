﻿using System.Xml.Serialization;
namespace Weather_Monitoring.DataFormat
{
    [XmlRoot("WeatherData", Namespace = "")]

    public class XmlWeatherData : WeatherData
    {
        public static XmlWeatherData FromXml(string xml)
        {
            var serializer = new XmlSerializer(typeof(XmlWeatherData));
            using (TextReader reader = new StringReader(xml))
            {
                var weatherData = (XmlWeatherData)serializer.Deserialize(reader);
                return weatherData;
            }
        }
    }
}