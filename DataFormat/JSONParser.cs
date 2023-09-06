using Newtonsoft.Json;
namespace Weather_Monitoring.DataFormat
{
    public class JSONParser 
    {
        public static WeatherData FromJson(string json)
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
    }
}