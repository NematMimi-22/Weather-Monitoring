using Newtonsoft.Json;
using System.Text.RegularExpressions;
namespace Weather_Monitoring.DataFormat
{
    public class JSONParser : IWetherDataParser
    {
        public  WeatherData Parse(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WeatherData>(json);
            }
            catch (JsonReaderException)
            {
                return null;
            }
        }

        public bool IsSupportedFormat(string inputFormat)
        {
            return Regex.IsMatch(inputFormat.Trim(), @"^{.*}$");
        }
    }
}