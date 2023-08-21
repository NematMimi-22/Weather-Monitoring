using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public interface IBaseBot
    {
        bool enabled { get; set; }
        string message { get; set; }
        string Name { get; }
        int Threshold { get; set; }

        void PerformAction();
        bool IsActivated(WeatherData weatherData);
    }
}