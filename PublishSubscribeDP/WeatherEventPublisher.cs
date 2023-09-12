using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.PublishSubscribeDP
{
    public class WeatherEventPublisher
    {
        public void PublishEvent(string eventName, WeatherData weatherData)
        {
            if (WeatherPublisher.subscribers.TryGetValue(eventName, out var subscribers))
            {
                foreach (var bot in subscribers)
                {
                    bot.PerformAction(weatherData);
                }
            }
        }
    }
}