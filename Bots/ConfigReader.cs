using Newtonsoft.Json;
namespace Weather_Monitoring.Bots
{
    public class ConfigReader
    {
        public static List<BaseBot> ReadConfig(string configFile)
        {
            var json = File.ReadAllText(configFile);
            var configDictionary = JsonConvert.DeserializeObject<Dictionary<string, BaseBot>>(json);
            foreach (var entry in configDictionary)
            {
                entry.Value.Name = entry.Key;
            }

            return configDictionary.Values.ToList();
        }
    }
}