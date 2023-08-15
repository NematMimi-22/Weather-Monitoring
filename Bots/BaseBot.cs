using Weather_Monitoring.DataFormat;

namespace Weather_Monitoring.Bots
{
    public class BaseBot
    {
        public string Name { get;  set; }
        public bool Enabled { get; set; }
        public int Threshold { get; set; }
        public string Message { get; set; }

        public virtual bool IsActivated(WeatherData weatherData)
        {
            return false;
        }

        public virtual void PerformAction()
        {
            Console.WriteLine($"{Name} activated.");
        }
    }
}