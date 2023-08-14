namespace Weather_Monitoring
{
    public abstract class WeatherData
    {
        protected dynamic Data { get; }

        public WeatherData(dynamic data)
        {
            Data = data;
        }
        public abstract string GetLocation();
        public abstract double GetTemperature();
        public abstract double GetHumidity();

    }
}
