namespace ExamSolid.LiskovSubstitutionPrinciple.CorrectExample
{
    // To'g'ri misol (Liskov o'rnini bosish printsipiga rioya qiladi):

    internal class Penguin : Bird
    {
        public override void Eat() { }
        // Pingvin ucholmaydi, shuning uchun Fly metodini bu yerda kiritmaymiz.
    }
}
