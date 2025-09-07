namespace ExamSolid.DependencyInversionPrinciple.BadExample
{
    // Yomon misol(qattiq bog'liqlik):

    internal class Notification
    {
        private readonly EmailSender sender = new EmailSender(); // Faqat Email ishlay oladi

        public void Send(string xabar)
        {
            sender.Send(xabar);
        }
    }
}
