namespace ExamSolid.SingleResponsibilityPrinciple.BadExample
{
    internal class InvoiceService
    {
        // Yomon misol (bir classda bir nechta mas'uliyat aralashgan):

        public void CalculateInvoice()
        {
            // Hisoblash
        }

        public void SaveToDatabase()
        {
            // Bazaga yozish
        }

        public void PrintInvoice()
        {
            // Printerga chiqarish
        }
    }
}
