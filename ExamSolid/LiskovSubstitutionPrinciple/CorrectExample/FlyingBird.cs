namespace ExamSolid.LiskovSubstitutionPrinciple.CorrectExample
{
    // To'g'ri misol (Liskov o'rnini bosish printsipiga rioya qiladi):

    internal abstract class FlyingBird : Bird
    {
        public abstract void Fly();
    }
}
