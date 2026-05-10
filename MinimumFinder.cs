using System;

// EN: Aufgabe 2 – Find the smallest of three numbers entered by the user.
// UA: Завдання 2 – Знайти найменше з трьох чисел, введених користувачем.

namespace Aufgabe02_MinimumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 2 – Kleinste Zahl";

            // EN: Read three numbers from the user
            // UA: Зчитуємо три числа від користувача
            Console.Write("Zahl 1: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zahl 2: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zahl 3: ");
            double zahl3 = Convert.ToDouble(Console.ReadLine());

            // EN: Determine the minimum using nested if-else comparisons
            // UA: Знаходимо мінімум за допомогою вкладених if-else перевірок
            double minimum;

            if (zahl1 <= zahl2 && zahl1 <= zahl3)
            {
                // EN: zahl1 is the smallest
                // UA: zahl1 є найменшим
                minimum = zahl1;
            }
            else if (zahl2 <= zahl1 && zahl2 <= zahl3)
            {
                // EN: zahl2 is the smallest
                // UA: zahl2 є найменшим
                minimum = zahl2;
            }
            else
            {
                // EN: zahl3 is the smallest
                // UA: zahl3 є найменшим
                minimum = zahl3;
            }

            Console.WriteLine($"Die kleinste Zahl ist {minimum}.");

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
