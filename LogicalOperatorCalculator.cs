using System;

// EN: Aufgabe 6 – Logical operator calculator
// The user selects a logical operation (OR / AND / NAND / XOR) and
// enters two binary values (x, y ∈ {0, 1}).
// The program outputs the result as 0 or 1.
//
// UA: Завдання 6 – Калькулятор логічних операторів
// Користувач обирає логічну операцію (OR / AND / NAND / XOR) і
// вводить два бінарних значення (x, y ∈ {0, 1}).
// Програма виводить результат як 0 або 1.

namespace Aufgabe06_LogikOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 6 – Logische Operatoren";

            // EN: Display the operator menu
            // UA: Показуємо меню операторів
            Console.WriteLine("Wählen Sie einen logischen Operator aus:");
            Console.WriteLine("UND:  1");
            Console.WriteLine("ODER: 2");
            Console.WriteLine("NAND: 3");
            Console.WriteLine("XOR:  4");
            Console.Write("Auswahl: ");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            // EN: Read the two binary operands
            // UA: Зчитуємо два бінарних операнди
            Console.WriteLine("Geben Sie die Werte für x und y ein:");
            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // EN: Convert integer inputs to bool for the logical operations
            // UA: Конвертуємо цілочисельні значення у bool для логічних операцій
            bool bx = (x == 1);
            bool by = (y == 1);

            bool ergebnisBool;

            // EN: Apply the selected logical operation
            // UA: Застосовуємо обрану логічну операцію
            switch (auswahl)
            {
                case 1: // AND / І
                    ergebnisBool = bx && by;
                    break;
                case 2: // OR / АБО
                    ergebnisBool = bx || by;
                    break;
                case 3: // NAND / НЕ-І  (negated AND)
                    ergebnisBool = !(bx && by);
                    break;
                case 4: // XOR / Виключне АБО
                    ergebnisBool = bx ^ by;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl!");
                    Console.ReadKey();
                    return;
            }

            // EN: Convert the boolean result back to 0 / 1 for output
            // UA: Перетворюємо булевий результат назад у 0 / 1 для виведення
            int ergebnis = ergebnisBool ? 1 : 0;
            Console.WriteLine($"Das Ergebnis ist {ergebnis}.");

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
