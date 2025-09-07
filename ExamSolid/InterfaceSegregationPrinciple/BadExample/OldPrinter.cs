using ExamSolid.InterfaceSegregationPrinciple.BadExample.Interfaces;

namespace ExamSolid.InterfaceSegregationPrinciple.BadExample
{
    // Yomon misol (katta, umumiy interfeys):

    internal class OldPrinter : IMachine
    {
        // Bu printer faqat chop etish funksiyasini qo'llab-quvvatlaydi,
        // lekin boshqa metodlarni amalga oshirishga majbur.

        public void Print() { }
        public void Scan() { throw new NotImplementedException(); } 
        public void Fax() { throw new NotImplementedException(); }
    }
}
