using System;

// EN: Aufgabe 5 – Weekly gross wage calculator
// The user enters weekly hours worked and the hourly rate.
// Every hour ABOVE 35 h/week is paid at 150 % (50 % surcharge).
// Input is rejected if: hours > 80  OR  hourly rate > 50.00 €.
// UA: Завдання 5 – Калькулятор тижневої брутто-зарплати
// Користувач вводить кількість відпрацьованих годин і ставку за годину.
// Кожна година ПОНАД 35 год/тиждень оплачується як 150% (надбавка 50%).
// Введення відхиляється, якщо: годин > 80  АБО  ставка > 50,00 €.

namespace Aufgabe05_Bruttolohn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 5 – Bruttolohnermittlung";

            // EN: Read hours worked per week
            // UA: Зчитуємо кількість відпрацьованих годин на тиждень
            Console.Write("Stunden: ");
            double stunden = Convert.ToDouble(Console.ReadLine());

            // EN: Read the hourly wage
            // UA: Зчитуємо годинну ставку
            Console.Write("Stundenlohn: ");
            double stundenlohn = Convert.ToDouble(Console.ReadLine());

            // EN: Validate input – reject invalid values immediately
            // UA: Перевірка введення – відхиляємо недійсні значення
            if (stunden > 80 || stundenlohn > 50.0)
            {
                Console.WriteLine("Ungültige Eingabe: Stunden > 80 oder Stundenlohn > 50,00 € sind nicht erlaubt.");
            }
            else
            {
                double bruttolohn;

                if (stunden <= 35)
                {
                    // EN: No overtime – pay the standard rate for all hours
                    // UA: Без понаднормових – оплата за звичайною ставкою
                    bruttolohn = stunden * stundenlohn;
                }
                else
                {
                    // EN: Regular pay for the first 35 hours,
                    // then 150 % for every hour beyond 35
                    // UA: Звичайна оплата за перші 35 годин,
                    // потім 150% за кожну годину понад 35
                    double regelAnteil     = 35 * stundenlohn;
                    double ueberstunden    = stunden - 35;
                    double ueberAnteil     = ueberstunden * stundenlohn * 1.5;
                    bruttolohn = regelAnteil + ueberAnteil;
                }

                Console.WriteLine($"Bruttolohn: {bruttolohn:N2} Euro");
            }

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
