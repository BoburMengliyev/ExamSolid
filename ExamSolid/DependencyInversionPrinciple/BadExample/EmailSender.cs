namespace ExamSolid.DependencyInversionPrinciple.BadExample
{
    // Yomon misol(qattiq bog'liqlik):

    internal class EmailSender
    {
        public void Send(string xabar) => Console.WriteLine("Email: " + xabar);
    }
}
