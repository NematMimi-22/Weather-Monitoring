using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public class SunBot : BaseBot
    {
        public double TemperatureThreshold { get; set; }
        public override bool IsActivated(WeatherData weatherData)
        {
            return weatherData.Temperature > TemperatureThreshold;
        }
        public override void PerformAction()
        {
            Console.WriteLine($"SunBot activated!");
        }
    }
}