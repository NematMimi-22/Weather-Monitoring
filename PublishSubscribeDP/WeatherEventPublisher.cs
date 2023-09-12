using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.PublishSubscribeDP
{
    public class WeatherEventPublisher
    {
        public void Publish(WeatherData weatherData)
        {
            foreach (var subscriber in WeatherEventSubscriber.subscribers)
            {
                subscriber.PerformAction(weatherData);
            }
        }
    }
}