using Weather_Monitoring.Bots;
namespace Weather_Monitoring.PublishSubscribeDP
{
    public class WeatherEventSubscriber
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
    }
}