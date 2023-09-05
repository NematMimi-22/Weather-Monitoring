using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.PublishSubscribeDP
{
    public class WeatherEventPublisher
    {
        public void PublishEvent(string eventName, WeatherData weatherData)
        {
            if (WeatherEventSubscriber.subscribers.TryGetValue(eventName, out var subscribers))
            {
                foreach (var bot in subscribers)
                {
                    var t = new WeatherEventSubscriber();
                    bot.PerformAction(weatherData);
                    t.Unsubscribe(eventName, (WeatherEventSubscriber)bot);

                }
            }
        }
    }
}