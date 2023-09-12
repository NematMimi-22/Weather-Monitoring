using Weather_Monitoring.Bots;
using Weather_Monitoring.PublishSubscribeDP;
using Xunit;
namespace Weather_Monitoring.WeatherMonitoringTest.PublishSubscribeDPTest
{
    public class WeatherEventSubscriberTests
    {
        [Theory]
        [InlineData(typeof(RainBot), 70, true, "Rain is expected")]
        [InlineData(typeof(SunBot), 80, true, "Sun is expected")]
        [InlineData(typeof(SnowBot), 32, true, "Snow is expected")]
        public void Subscribe_AddsBotToEvent(Type botType, int threshold, bool isActive, string message)
        {
            // Arrange
            var subscriber = new WeatherEventSubscriber();
            var eventName = "Event1";
            var bot = (IBot)Activator.CreateInstance(botType, new object[] { threshold, isActive, message });

            // Act
            subscriber.Subscribe(bot);

            // Assert
            Assert.Contains(bot, WeatherEventSubscriber.subscribers);
        }

        [Theory]
        [InlineData(typeof(RainBot), 70, true, "Rain is expected")]
        [InlineData(typeof(SunBot), 80, true, "Sun is expected")]
        [InlineData(typeof(SnowBot), 32, true, "Snow is expected")]
        public void Unsubscribe_RemovesBotFromEvent(Type botType, int threshold, bool isActive, string message)
        {
            // Arrange
            var subscriber = new WeatherEventSubscriber();
            var eventName = "Event1";
            var bot = (IBot)Activator.CreateInstance(botType, new object[] { threshold, isActive, message });
            subscriber.Subscribe(bot);

            // Act
            subscriber.Unsubscribe(bot);

            // Assert
            Assert.DoesNotContain(bot, WeatherEventSubscriber.subscribers);
        }
    }
}