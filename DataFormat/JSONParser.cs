using Newtonsoft.Json;
namespace Weather_Monitoring.DataFormat
{
    public interface IWetherDataParser
    {
        WeatherData Parse(string input);
        bool IsSupportedFormat(input)
    }

    public class JSONParser : IWetherDataParser
    {
        public  WeatherData Parse(string input)
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
        public  bool IsSupportedFormat(string inputFormat)
        {
            return Regex.IsMatch(inputFormat.Trim(), @"^<.*>$");
        }
    }
}