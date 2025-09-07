namespace ExamSolid.LiskovSubstitutionPrinciple.CorrectExample
{
    // To'g'ri misol (Liskov o'rnini bosish printsipiga rioya qiladi):

    internal class Sparrow : FlyingBird
    {
        public override void Eat() { }
        public override void Fly() { }
    }
}
