using ExamSolid.InterfaceSegregationPrinciple.CorrectExample.Interfaces;

namespace ExamSolid.InterfaceSegregationPrinciple.CorrectExample
{
    // To'g'ri misol (interfeyslarni kichik va aniq qilish):

    internal class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print() { }
        public void Scan() { }
        public void Fax() { }
    }
}
