using Weather_Monitoring.DataFormat;

namespace Weather_Monitoring.Bots
{
    public class SunBot : BaseBot
    {
        public double temperatureThreshold;

        public override bool IsActivated(WeatherData weatherData)
        {
            return weatherData.Temperature > temperatureThreshold;
        }

        public override void PerformAction()
        {
            Console.WriteLine($"SunBot activated");
        }
    }
}