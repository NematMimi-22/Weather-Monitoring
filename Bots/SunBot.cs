using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public class SunBot : IBot
    {
        public double TemperatureThreshold { get; set; }
        public bool enabled { get; set; }
        public string message { get; set; }
        public string Name { get; } = "SunBot";
        public int Threshold { get; set; }

        public SunBot(double TemperatureThreshold, bool enabled, string message)
        {
            this.TemperatureThreshold = TemperatureThreshold;
            this.enabled = enabled;
            this.message = message;
        }

        public bool PerformAction(WeatherData weatherData)
        {
            if (weatherData.Temperature > TemperatureThreshold)
            {
                Console.WriteLine($"SunBot activated!");
                Console.WriteLine($"{Name}: {message}");
                return true;

            }
            return false;
        }
    }
}