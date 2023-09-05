using Newtonsoft.Json;
namespace Weather_Monitoring.DataFormat
{
    public class JSONParser 
    {
        public static WeatherData FromJson(string json)
        {
            return JsonConvert.DeserializeObject<WeatherData>(json);
        }
    }
}