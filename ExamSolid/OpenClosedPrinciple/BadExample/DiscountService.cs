namespace ExamSolid.OpenClosedPrinciple.BadExample
{
    // Yangi chegirma qo'shish uchun kodni o'zgartirishga majburmiz.

    internal class DiscountService
    {
        public decimal ApplyDiscount(string chegirma, decimal miqdori)
        {
            if (chegirma == "Yangi yil")
                return miqdori * 0.9m;
            else if (chegirma == "Hayit")
                return miqdori * 0.85m;
            else
                return miqdori;
        }
    }
}
