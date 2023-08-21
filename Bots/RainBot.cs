using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public class RainBot : IBaseBot
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

        public bool IsActivated(WeatherData weatherData)
        {
            return weatherData.Humidity > HumidityThreshold;
        }

        public void PerformAction()
        {
            Console.WriteLine($"RainBot activated!");
        }
    }
}