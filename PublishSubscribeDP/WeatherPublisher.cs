using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;

namespace Weather_Monitoring.PublishSubscribeDP
{
    public class WeatherPublisher
    {
        public static HashSet<IBot> subscribers = new();


        public void Subscribe( IBot bot)
        {
            subscribers.Add(bot);
        }

        public void Unsubscribe(IBot bot)
        {
                subscribers.Remove(bot);
        }

        public void Publish(WeatherData)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.PerformAction(WeatherData);
            }
        }
    }
}