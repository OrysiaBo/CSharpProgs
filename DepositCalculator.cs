using System;

// EN: Aufgabe 4 – Fixed-deposit interest calculator
// A bank applies tiered interest rates depending on the deposit amount:
//       up to  5 000 € → 2.00 %
//       up to 10 000 € → 2.25 %
//       up to 50 000 € → 2.50 %
//       over 50 000 € → 2.75 %
//
// UA: Завдання 4 – Калькулятор відсотків по депозиту
// Банк застосовує ступінчасті відсоткові ставки залежно від суми вкладу:
//       до  5 000 €  → 2,00 %
//       до 10 000 €  → 2,25 %
//       до 50 000 €  → 2,50 %
//       понад 50 000 € → 2,75 %

namespace Aufgabe04_Festgeldzinsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 4 – Festgeldzinsen";

            // EN: Read the deposit amount from the user
            // UA: Зчитуємо суму вкладу від користувача
            Console.Write("Anlagebetrag in Euro: ");
            double anlagebetrag = Convert.ToDouble(Console.ReadLine());

            // EN: Select the applicable interest rate based on the deposit bracket
            // UA: Вибираємо відповідну відсоткову ставку на основі рівня вкладу
            double zinssatz;

            if (anlagebetrag <= 5000.0)
            {
                zinssatz = 2.00;
            }
            else if (anlagebetrag <= 10000.0)
            {
                zinssatz = 2.25;
            }
            else if (anlagebetrag <= 50000.0)
            {
                zinssatz = 2.50;
            }
            else
            {
                zinssatz = 2.75;
            }

            // EN: Calculate annual interest: principal × rate / 100
            // UA: Розраховуємо річні відсотки: сума × ставка / 100
            double zinsen = anlagebetrag * zinssatz / 100.0;

            Console.WriteLine($"Zinsen pro Jahr in Euro: {zinsen:N2}");

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
