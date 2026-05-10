using System;

// EN: Aufgabe 7 – Even / odd checker
//     The user enters a positive integer.
//     The program uses the modulo operator (%) to determine
//     whether the number is even or odd.
//
// UA: Завдання 7 – Перевірка парного / непарного числа
//     Користувач вводить позитивне ціле число.
//     Програма використовує оператор остачі (%) для визначення,
//     чи є число парним або непарним.

namespace Aufgabe07_GeradePruefung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 7 – Gerade oder ungerade?";

            // EN: Read a positive integer from the user
            // UA: Зчитуємо позитивне ціле число від користувача
            Console.Write("Zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            // EN: A number is even when dividing by 2 leaves no remainder (% 2 == 0).
            // UA: Число парне, якщо ділення на 2 не дає остачі (% 2 == 0).
            if (zahl % 2 == 0)
            {
                Console.WriteLine($"Die Zahl {zahl} ist eine gerade Zahl.");
            }
            else
            {
                Console.WriteLine($"Die Zahl {zahl} ist eine ungerade Zahl.");
            }

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
