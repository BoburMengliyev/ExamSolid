## SOLID nima?

SOLID — bu 5 ta asosiy tamoyildan tashkil topgan qisqartma bo‘lib, kodni moslashuvchan, o‘qilishi oson, qayta ishlashga qulay va xatolarga chidamli qilish uchun ishlatiladi.
Ularni dastlab Robert C. Martin (Uncle Bob) ishlab chiqqan.

## S – Single Responsibility Principle (SRP)

Har bir class (yoki modul) faqat bitta vazifani bajarishi kerak.
Aks holda, kod murakkablashib, uni tushunish va o‘zgartirish qiyinlashadi.

Yomon misol:
Bitta class ichida ham chiqarish, ham saqlash, ham hisoblash vazifalari jamlangan bo‘lsa.

## O – Open/Closed Principle (OCP)

Classlar kengaytirishga ochiq, lekin o‘zgartirishga yopiq bo‘lishi kerak.
Ya’ni yangi funksiyalar qo‘shishda mavjud kodni o‘zgartirmaslik kerak.

## L – Liskov Substitution Principle (LSP)

Vorislashgan class (child) ota class (parent) o‘rnida bemalol ishlay olishi kerak.

## I – Interface Segregation Principle (ISP)

Bir katta interfeys o‘rniga — bir nechta kichik, aniq interfeyslar bo‘lishi kerak.
Classlar o‘ziga keraksiz metodlarni implement qilishga majbur bo‘lmasligi kerak.

## D – Dependency Inversion Principle (DIP)

Yuqori darajadagi modullar past darajadagi modullarga bog‘liq bo‘lmasligi kerak.
Ikkalasi ham abstraksiyaga bog‘liq bo‘lishi kerak.

Xulosa

- S – Har class bitta vazifaga ega bo‘lsin.

- O – Kodni o‘zgartirmasdan kengaytirish mumkin bo‘lsin.

- L – Voris class ota class o‘rnida ishlasin.

- I – Interfeyslar kichik va aniq bo‘lsin.

- D – Modullar abstraksiyaga tayanib ishlasin.
