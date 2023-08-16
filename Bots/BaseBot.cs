using Weather_Monitoring.DataFormat;

namespace Weather_Monitoring.Bots
{
    public class BaseBot
    {
        public string Name { get;  set; }
        public bool enabled { get; set; }
        public virtual int Threshold { get; set; }
        public string message { get; set; }

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