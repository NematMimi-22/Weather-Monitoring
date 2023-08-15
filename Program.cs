using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the weather data:");
            var Input = Console.ReadLine();
            var weatherData = WeatherDataFactory.CreateReader(Input);
            Console.WriteLine($"Location: {weatherData.Location}");
            Console.WriteLine($"Temperature: {weatherData.Temperature}");
            Console.WriteLine($"Humidity: {weatherData.Humidity}");
            var configFile = @"C:\Users\Nemat\source\repos\Weather-Monitoring\config.json";
            var botConfigs = ConfigReader.ReadConfig(configFile);
            foreach (var botConfig in botConfigs)
            {
                Console.WriteLine($"Name: {botConfig.Name}");
                Console.WriteLine($"Enabled: {botConfig.Enabled}");
                Console.WriteLine($"Threshold: {botConfig.Threshold}");
                Console.WriteLine($"Message: {botConfig.Message}");
                Console.WriteLine();
            }
        }
    }
}