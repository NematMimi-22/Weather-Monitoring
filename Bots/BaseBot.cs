using Weather_Monitoring.DataFormat;
namespace Weather_Monitoring.Bots
{
    public class BaseBot
    {
        public string Name { get;  set; }
        public bool enabled { get; set; }
        public virtual int Threshold { get; set; }
        public string message { get; set; }

        public virtual void PerformAction()
        {
            Console.WriteLine($"{Name} activated.");
        }
    }
}