using System;

// EN: Aufgabe 3 – Customer bonus calculator
// A company grants a 5 % bonus if the customer's annual net turnover exceeds 70 000 €.
// Otherwise a message is printed that no bonus is granted.
//
// UA: Завдання 3 – Калькулятор бонусу клієнта
// Компанія нараховує 5% бонус, якщо річний нетто-оборот клієнта перевищує 70 000 €.
// Інакше виводиться повідомлення про відсутність бонусу.

namespace Aufgabe03_Bonusberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 3 – Bonusberechnung";

            // EN: Read the customer's annual net turnover
            // UA: Зчитуємо річний нетто-оборот клієнта
            Console.Write("Nettoumsatz in Euro: ");
            double nettoumsatz = Convert.ToDouble(Console.ReadLine());

            // EN: Check whether the threshold of 70 000 € is exceeded
            // UA: Перевіряємо, чи перевищено поріг у 70 000 €
            if (nettoumsatz > 70000.0)
            {
                // EN: Calculate the 5 % bonus
                // UA: Розраховуємо 5% бонус
                double bonus = nettoumsatz * 0.05;
                Console.WriteLine($"Bonus in Euro: {bonus:N2}");
            }
            else
            {
                // EN: The customer has not reached the required turnover
                // UA: Клієнт не досяг необхідного обороту
                Console.WriteLine("Kein Bonus – der erforderliche Umsatz wurde nicht erreicht.");
            }

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
