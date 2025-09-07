using ExamSolid.DependencyInversionPrinciple.CorrectExample.Interfaces;

namespace ExamSolid.DependencyInversionPrinciple.CorrectExample
{
    // Endi Notification SMS, Email, Telegram yoki boshqa kanallar bilan ham ishlay oladi.

    internal class Notification
    {
        private readonly IMessageSender sender;

        public Notification(IMessageSender sender)
        {
            sender = sender;
        }

        public void Send(string xabar)
        {
            sender.Send(xabar);
        }
    }
}
