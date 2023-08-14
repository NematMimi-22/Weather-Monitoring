namespace Weather_Monitoring.Bots
{
    public class BaseBot
    {
        public string Name { get;  set; }
        public virtual void PerformAction()
        {
            Console.WriteLine($"{Name} activated.");
        }
    }
}