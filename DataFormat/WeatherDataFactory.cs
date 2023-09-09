using System.Text.RegularExpressions;

namespace Weather_Monitoring.DataFormat
{
    public class WeatherDataFactory
    {
        public static WeatherData CreateReader(string inputFormat)
        {
            if (IsJSONFormat(inputFormat))
            {
                return JSONParser.FromJson(inputFormat);
            }
            if (IsXMLFormat(inputFormat))
            {
                return XmlParser.FromXml(inputFormat);
            }
            throw new ArgumentException("Unsupported input format");
        }

        private static bool IsXMLFormat(string inputFormat)
        {
            return Regex.IsMatch(inputFormat.Trim(), @"^<.*>$");
        }

        private static bool IsJSONFormat(string inputFormat)
        {
            return Regex.IsMatch(inputFormat.Trim(), @"^{.*}$");
        }
    }
}