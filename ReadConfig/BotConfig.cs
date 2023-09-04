namespace Weather_Monitoring.ReadConfig
{
    public class BotConfig
    {
        public bool Enabled { get; set; }
        public int Threshold { get; set; }
        public string Message { get; set; }

        public BotConfig(bool Enabled, int Threshold, string Message)
        {
            this.Enabled = Enabled;
            this.Threshold = Threshold;
            this.Message = Message;
        }
    }
}