using Newtonsoft.Json;
using System.Text.RegularExpressions;
namespace Weather_Monitoring.DataFormat
{
    public class JSONParser : IWetherDataParser
    {
        public  WeatherData Parse(string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<WeatherData>(input);
            }
            catch (JsonReaderException)
            {
                return null;
            }
        }

        public bool IsSupportedFormat(string input)
        {
            return Regex.IsMatch(input.Trim(), @"^{.*}$");
        }
    }
}