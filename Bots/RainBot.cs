using Weather_Monitoring.DataFormat;

namespace Weather_Monitoring.Bots
{
    public class RainBot : BaseBot
    {
        public int HumidityThreshold { get; set; }
        public override bool IsActivated(WeatherData weatherData)
        {
            return weatherData.Humidity > HumidityThreshold;
        }

        public override void PerformAction()
        {
            Console.WriteLine($"RainBot activated!");
        }
    }
}