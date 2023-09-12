namespace Weather_Monitoring.DataFormat
{
    public interface IWetherDataParser
    {
        WeatherData Parse(string input);
        bool IsSupportedFormat(string input);
    }
}
