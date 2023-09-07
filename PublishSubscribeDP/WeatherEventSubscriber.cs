using Weather_Monitoring.Bots;
namespace Weather_Monitoring.PublishSubscribeDP
{
    public class WeatherEventSubscriber
    {
        public static Dictionary<string, List<IBot>> subscribers = new Dictionary<string, List<IBot>>();

        public void Subscribe(string eventName, IBot bot)
        {
            if (!subscribers.ContainsKey(eventName))
            {
                subscribers[eventName] = new List<IBot>();
            }
            subscribers[eventName].Add(bot);
        }

        public void Unsubscribe(string eventName, IBot bot)
        {
            if (subscribers.ContainsKey(eventName))
            {
                subscribers[eventName].Remove(bot);
            }
        }
    }
}