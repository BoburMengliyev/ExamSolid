using ExamSolid.OpenClosedPrinciple.CorrectExample.Interfaces;

namespace ExamSolid.OpenClosedPrinciple.CorrectExample.Services
{
    // To'g'ri misol (interfeys orqali kengaytiramiz):

    internal class DiscountService
    {
        private readonly IDiscount chegirma;

        public DiscountService(IDiscount discount)
        {
            chegirma = discount;
        }

        public decimal GetDiscountedPrice(decimal miqdor)
        {
            return chegirma.ApplyDiscount(miqdor);
        }
    }
}
