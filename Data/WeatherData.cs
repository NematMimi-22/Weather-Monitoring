﻿using System.Xml.Serialization;

namespace Weather_Monitoring.Data
{
    [XmlRoot("WeatherData", Namespace = "")]

    public abstract class WeatherData
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }
}