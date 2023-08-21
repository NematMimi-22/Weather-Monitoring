using Weather_Monitoring.Bots;
namespace Weather_Monitoring.PrinterService
{
    public class BotMessagePrinter
    {
        public static void PrintBotMessage(IBaseBot bot)
        {
                Console.WriteLine($"{bot.Name}: {bot.message}");
        }
    }
}