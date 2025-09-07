namespace ExamSolid.LiskovSubstitutionPrinciple.BadExample
{
    // Yomon misol (Liskov o'rnini bosish printsipiga zid):

    internal class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException(); // Pingvin ucholmaydi!
        }
    }
}
