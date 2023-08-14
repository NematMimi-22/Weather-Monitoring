using Weather_Monitoring.Data;
namespace Weather_Monitoring
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter JSON data:");
            var jsonInput = Console.ReadLine();
            JSONWeatherData jsonweatherData = JSONWeatherData.FromJson(jsonInput);
            Console.WriteLine($"Location: {jsonweatherData.Location}");
            Console.WriteLine($"Temperature: {jsonweatherData.Temperature}");
            Console.WriteLine($"Humidity: {jsonweatherData.Humidity}");
        }
    }
}