using Weather_Monitoring.Bots;
using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter JSON data:");
            var jsonInput = Console.ReadLine();
            var jsonweatherData = JSONWeatherData.FromJson(jsonInput);
            Console.WriteLine($"Location: {jsonweatherData.Location}");
            Console.WriteLine($"Temperature: {jsonweatherData.Temperature}");
            Console.WriteLine($"Humidity: {jsonweatherData.Humidity}");
         
            Console.WriteLine("Enter JSON data:");
            var xmlInput = Console.ReadLine();
            var xmlweatherData = XmlWeatherData.FromXml(xmlInput);
            Console.WriteLine($"Location: {xmlweatherData.Location}");
            Console.WriteLine($"Temperature: {xmlweatherData.Temperature}");
            Console.WriteLine($"Humidity: {xmlweatherData.Humidity}");
       
            string configFile = @"C:\Users\Nemat\source\repos\Weather-Monitoring\config.json";
            List<BaseBot> botConfigs = ConfigReader.ReadConfig(configFile);

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