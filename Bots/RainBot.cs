namespace Weather_Monitoring.Bots
{
    public class RainBot : BaseBot
    {
        public int humidityThreshold = 80; // 80 just for test

        public override void PerformAction()
        {
            Console.WriteLine($"RainBot activated due to high humidity ({humidityThreshold}%).");
        }
    }
}