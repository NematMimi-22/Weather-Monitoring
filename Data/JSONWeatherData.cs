using Newtonsoft.Json;

namespace Weather_Monitoring.Data
{
    public class JSONWeatherData : WeatherData
    {
        public static JSONWeatherData FromJson(string json)
        {
            var weatherData = JsonConvert.DeserializeObject<JSONWeatherData>(json);
            return weatherData;
        }
    }
}