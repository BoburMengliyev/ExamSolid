using ExamSolid.OpenClosedPrinciple.CorrectExample.Interfaces;

namespace ExamSolid.OpenClosedPrinciple.CorrectExample
{
    // To'g'ri misol (interfeys orqali kengaytiramiz):

    internal class NewYearDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal miqdori) => miqdori * 0.9m;
    }
}
