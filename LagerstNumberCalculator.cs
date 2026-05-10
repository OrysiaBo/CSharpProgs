using System;

// EN: Aufgabe 8 – Find the largest of four numbers.
// The user enters four numbers; the program prints the maximum value.
//
// UA: Завдання 8 – Знайти найбільше з чотирьох чисел.
// Користувач вводить чотири числа; програма виводить максимальне значення.

namespace Aufgabe08_MaximumVierZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 8 – Größte Zahl";

            // EN: Read four numbers from the user
            // UA: Зчитуємо чотири числа від користувача
            Console.Write("Zahl1: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zahl2: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zahl3: ");
            double zahl3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zahl4: ");
            double zahl4 = Convert.ToDouble(Console.ReadLine());

            // EN: Start by assuming the first number is the maximum,
            // then update whenever a larger value is found.
            // UA: Починаємо з припущення, що перше число є максимумом,
            // потім оновлюємо, коли знаходимо більше значення.
            double maximum = zahl1;

            if (zahl2 > maximum)
                maximum = zahl2;

            if (zahl3 > maximum)
                maximum = zahl3;

            if (zahl4 > maximum)
                maximum = zahl4;

            Console.WriteLine($"Die größte Zahl ist {maximum}.");

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
