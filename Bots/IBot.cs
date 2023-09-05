using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public interface IBot
    {
        bool enabled { get; set; }
        string message { get; set; }
        string Name { get; }
        int Threshold { get; set; }

        bool PerformAction(WeatherData weatherData);
    }
}