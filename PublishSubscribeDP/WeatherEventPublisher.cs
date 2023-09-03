using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.PublishSubscribeDP
{
    public class WeatherEventPublisher
    {
        public void PublishEvent(string eventName, WeatherData weatherData)
        {
            if (WeatherEventSubscriber.subscribers.ContainsKey(eventName))
            {
                foreach (var bot in WeatherEventSubscriber.subscribers[eventName])
                {
                    bot.PerformAction(weatherData);
                }
            }
        }
    }
}