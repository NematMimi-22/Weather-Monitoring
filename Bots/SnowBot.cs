using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public class SnowBot : IBot
    {
        public double TemperatureThreshold { get; set; }
        public bool enabled { get; set; }
        public string message { get; set; }
        public string Name { get; } = "SnowBot";
        public int Threshold { get; set; }

        public SnowBot(double TemperatureThreshold, bool enabled, string message)
        {
            this.TemperatureThreshold = TemperatureThreshold;
            this.enabled = enabled;
            this.message = message;
        }

        public bool IsActivated(WeatherData weatherData)
        {
            return weatherData.Temperature < TemperatureThreshold;
        }

        public void PerformAction()
        {
            Console.WriteLine($"SnowBot activated!");
        }
    }
}