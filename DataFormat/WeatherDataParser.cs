using System.Text.RegularExpressions;

namespace Weather_Monitoring.DataFormat
{
    public class WeatherDataParser
    {
        private readonly IEnumerable<IWetherDataParser> _parsers;
        public WeatherDataParser(IEnumerable<IWetherDataParser> parsers)
        {
            _parsers = parsers;
        }
        public WeatherDataParser()
        {
        }
        public WeatherData ParseInput(string inputFormat)
        {
            var parser = _parsers.FirstOrDefault(parser => parser.IsSupportedFormat(inputFormat));
            if (parser == null)
            {
                throw new ArgumentException("Unsupported input format");
            }

            return parser.Parse(inputFormat);
        }
    }
}