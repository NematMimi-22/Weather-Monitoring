using Newtonsoft.Json;
namespace Weather_Monitoring.DataFormat
{
    public class JSONWeatherData : WeatherData
    {
        public static JSONWeatherData FromJson(string json)
        {
            return JsonConvert.DeserializeObject<JSONWeatherData>(json);
        }
    }
}