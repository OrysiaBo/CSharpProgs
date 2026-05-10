using System;

// EN: Aufgabe 9 – Leap year checker
//     A year is a leap year when:
//       (divisible by 4  AND  NOT divisible by 100)
//       OR
//       (divisible by 4  AND  divisible by 100  AND  divisible by 400)
//     Simplified rule: (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)
//
// UA: Завдання 9 – Перевірка високосного року
//     Рік є високосним, якщо:
//       (ділиться на 4  І  НЕ ділиться на 100)
//       АБО
//       (ділиться на 4  І  ділиться на 100  І  ділиться на 400)
//     Спрощене правило: (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)

namespace Aufgabe09_Schaltjahrpruefung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 9 – Schaltjahrprüfung";

            // EN: Read the year from the user
            // UA: Зчитуємо рік від користувача
            Console.Write("Jahr: ");
            int jahr = Convert.ToInt32(Console.ReadLine());

            // EN: Apply the leap-year rule using modulo checks
            // UA: Застосовуємо правило високосного року через перевірки остачі
            bool istSchaltjahr = (jahr % 4 == 0 && jahr % 100 != 0)
                                 || (jahr % 400 == 0);

            if (istSchaltjahr)
            {
                Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr.");
            }
            else
            {
                Console.WriteLine($"Das Jahr {jahr} ist kein Schaltjahr.");
            }

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
