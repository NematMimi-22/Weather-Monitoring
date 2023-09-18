using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public class RainBot : IBot
    {
        public int HumidityThreshold { get; set; }
        public bool enabled { get; set; }
        public string message { get; set; }
        public string Name { get; } = "RainBot";
        public int Threshold { get; set; }

        public RainBot(int HumidityThreshold, bool enabled, string message) 
        {
            this.HumidityThreshold = HumidityThreshold;
            this.enabled = enabled;
            this.message = message;
        }

        public bool PerformAction(WeatherData weatherData)
        {
            if (weatherData.Humidity > HumidityThreshold && enabled)
            {
                Console.WriteLine($"RainBot activated!");
                Console.WriteLine($"{Name}: {message}");
                return true;
            }
            return false;
        }
    }
}