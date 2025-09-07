## 🔹 SOLID nima?

SOLID — bu 5 ta asosiy tamoyildan tashkil topgan qisqartma bo‘lib, kodni moslashuvchan, o‘qilishi oson, qayta ishlashga qulay va xatolarga chidamli qilish uchun ishlatiladi.
Ularni dastlab Robert C. Martin (Uncle Bob) ishlab chiqqan.

1️⃣ S – Single Responsibility Principle (SRP)

👉 Har bir class (yoki modul) faqat bitta vazifani bajarishi kerak.
Aks holda, kod murakkablashib, uni tushunish va o‘zgartirish qiyinlashadi.

```csharp
public class InvoicePrinter
{
    public void PrintInvoice(Invoice invoice)
    {
        // Faqat chiqarish (print) uchun javobgar
        Console.WriteLine($"Invoice ID: {invoice.Id}, Amount: {invoice.Amount}");
    }
}

public class InvoiceSaver
{
    public void SaveInvoice(Invoice invoice)
    {
        // Faqat saqlash uchun javobgar
        // Masalan: DB ga yozish
    }
}
```

❌ Yomon misol:
Bitta class ichida ham chiqarish, ham saqlash, ham hisoblash vazifalari jamlangan bo‘lsa.

2️⃣ O – Open/Closed Principle (OCP)

👉 Classlar kengaytirishga ochiq, lekin o‘zgartirishga yopiq bo‘lishi kerak.
Ya’ni yangi funksiyalar qo‘shishda mavjud kodni o‘zgartirmaslik kerak.

✅ Yaxshi misol (strategy pattern):

```csharp
public interface IDiscount
{
    decimal ApplyDiscount(decimal amount);
}

public class NewYearDiscount : IDiscount
{
    public decimal ApplyDiscount(decimal amount) => amount * 0.9m;
}

public class EidDiscount : IDiscount
{
    public decimal ApplyDiscount(decimal amount) => amount * 0.85m;
}
```

Agar yangi chegirma qo‘shmoqchi bo‘lsak — interfeysni implement qilamiz, eski kodni o‘zgartirmaymiz.

3️⃣ L – Liskov Substitution Principle (LSP)

👉 Vorislashgan class (child) ota class (parent) o‘rnida bemalol ishlay olishi kerak.

✅ Yaxshi misol:

```csharp
public abstract class Bird
{
    public abstract void Fly();
}

public class Sparrow : Bird
{
    public override void Fly() => Console.WriteLine("Sparrow is flying");
}
```

❌ Yomon misol:

```csharp
public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException(); // ❌ Pingvin ucholmaydi!
    }
}
```

👉 Bu LSP ga zid, chunki Penguin ni Bird o‘rnida ishlatib bo‘lmaydi. To‘g‘risi — “uchadigan qushlar” va “uchmaydigan qushlar”ni alohida abstraktsiyaga ajratish.

4️⃣ I – Interface Segregation Principle (ISP)

👉 Bir katta interfeys o‘rniga — bir nechta kichik, aniq interfeyslar bo‘lishi kerak.
Classlar o‘ziga keraksiz metodlarni implement qilishga majbur bo‘lmasligi kerak.

✅ Yaxshi misol:

```csharp
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print() { }
    public void Scan() { }
}

public class SimplePrinter : IPrinter
{
    public void Print() { }
}
```

4️⃣ I – Interface Segregation Principle (ISP)

👉 Bir katta interfeys o‘rniga — bir nechta kichik, aniq interfeyslar bo‘lishi kerak.
Classlar o‘ziga keraksiz metodlarni implement qilishga majbur bo‘lmasligi kerak.

✅ Yaxshi misol:

```csharp
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print() { }
    public void Scan() { }
}

public class SimplePrinter : IPrinter
{
    public void Print() { }
}
```

❌ Yomon misol:

```
public interface IMachine
{
    void Print();
    void Scan();
    void Fax();
}

public class OldPrinter : IMachine
{
    public void Print() { }
    public void Scan() { throw new NotImplementedException(); } // ❌
    public void Fax() { throw new NotImplementedException(); }   // ❌
}
```

5️⃣ D – Dependency Inversion Principle (DIP)

👉 Yuqori darajadagi modullar past darajadagi modullarga bog‘liq bo‘lmasligi kerak.
Ikkalasi ham abstraksiyaga bog‘liq bo‘lishi kerak.

✅ Yaxshi misol (DI + Interface):

```csharp
public interface IMessageSender
{
    void Send(string message);
}

public class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"Email: {message}");
}

public class Notification
{
    private readonly IMessageSender _sender;

    public Notification(IMessageSender sender)
    {
        _sender = sender;
    }

    public void SendNotification(string message)
    {
        _sender.Send(message);
    }
}
```

👉 Bu yerda Notification classi EmailSender ga qattiq bog‘liq emas.
Xohlasak, SmsSender, WhatsAppSender qo‘shib ishlata olamiz.

✅ Xulosa

- S – Har class bitta vazifaga ega bo‘lsin.

- O – Kodni o‘zgartirmasdan kengaytirish mumkin bo‘lsin.

- L – Voris class ota class o‘rnida ishlasin.

- I – Interfeyslar kichik va aniq bo‘lsin.

- D – Modullar abstraksiyaga tayanib ishlasin.
