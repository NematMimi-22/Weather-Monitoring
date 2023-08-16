using System.Text.RegularExpressions;

namespace Weather_Monitoring.DataFormat
{
    public class WeatherDataFactory
    {
        public static WeatherData CreateReader(string inputFormat)
        {
            if (Regex.IsMatch(inputFormat.Trim(), @"^{.*}$"))
            {
                return JSONWeatherData.FromJson(inputFormat);
            }
            else if (Regex.IsMatch(inputFormat.Trim(), @"^<.*>$"))
            {
                return XmlWeatherData.FromXml(inputFormat);
            }
            else
            {
                throw new ArgumentException("Unsupported input format");
            }
        }
    }
}