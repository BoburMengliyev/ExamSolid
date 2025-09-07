using ExamSolid.DependencyInversionPrinciple.CorrectExample.Interfaces;

namespace ExamSolid.DependencyInversionPrinciple.CorrectExample
{
    // To'g'ri misol (interfeys orqali bog'lanamiz):

    internal class SmsSender : IMessageSender
    {
        public void Send(string xabar) => Console.WriteLine("SMS: " + xabar);
    }
}
