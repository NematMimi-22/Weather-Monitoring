namespace Weather_Monitoring.Bots
{
    public class BaseBot
    {
        public string Name { get;  set; }
        public bool Enabled { get; set; }
        public int Threshold { get; set; }
        public string Message { get; set; }
        public virtual void PerformAction()
        {
            Console.WriteLine($"{Name} activated.");
        }
    }
}