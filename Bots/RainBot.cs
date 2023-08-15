using Weather_Monitoring.DataFormat;

namespace Weather_Monitoring.Bots
{
    public class RainBot : BaseBot
    {
        public int humidityThreshold; 

        public override bool IsActivated(WeatherData weatherData)
        {
            return weatherData.Humidity > humidityThreshold;
        }

        public override void PerformAction()
        {
            Console.WriteLine($"RainBot activated");
        }
    }
}