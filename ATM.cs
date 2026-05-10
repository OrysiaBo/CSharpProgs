using System;

// EN: Aufgabe 10 – ATM simulator
// The user picks a preset amount (100 €, 200 €, 500 €) or enters
// a custom amount between 10 € and 1 000 € (multiples of 10, since
// the smallest available banknote is 10 €).
// Invalid inputs produce an appropriate error message.
// UA: Завдання 10 – Симулятор банкомату
// Користувач обирає фіксовану суму (100 €, 200 €, 500 €) або вводить
// довільну суму від 10 € до 1 000 € (кратну 10, оскільки
// найменша купюра – 10 €).
// Невірні введення призводять до відповідного повідомлення про помилку.

namespace Aufgabe10_Bankautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 10 – Bankautomat";

            // EN: Display the withdrawal menu
            // UA: Показуємо меню зняття коштів
            Console.WriteLine("Wählen Sie bitte einen Betrag aus dem Menü aus und");
            Console.WriteLine("geben Sie die entsprechende Zahl ein.\n");
            Console.WriteLine("Auswahlmenü");
            Console.WriteLine("  1. Auszahlung 100,- Euro");
            Console.WriteLine("  2. Auszahlung 200,- Euro");
            Console.WriteLine("  3. Auszahlung 500,- Euro");
            Console.WriteLine("  4. Anderer Betrag");
            Console.Write("\nEingabe: ");
            int auswahl = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            double betrag;

            switch (auswahl)
            {
                case 1:
                    // EN: Fixed withdrawal of 100 €
                    // UA: Фіксоване зняття 100 €
                    betrag = 100.0;
                    Console.WriteLine($"Sie bekommen {betrag:N0},- Euro ausgezahlt.");
                    Console.WriteLine("Wir wünschen Ihnen noch einen schönen Tag.");
                    break;

                case 2:
                    // EN: Fixed withdrawal of 200 €
                    // UA: Фіксоване зняття 200 €
                    betrag = 200.0;
                    Console.WriteLine($"Sie bekommen {betrag:N0},- Euro ausgezahlt.");
                    Console.WriteLine("Wir wünschen Ihnen noch einen schönen Tag.");
                    break;

                case 3:
                    // EN: Fixed withdrawal of 500 €
                    // UA: Фіксоване зняття 500 €
                    betrag = 500.0;
                    Console.WriteLine($"Sie bekommen {betrag:N0},- Euro ausgezahlt.");
                    Console.WriteLine("Wir wünschen Ihnen noch einen schönen Tag.");
                    break;

                case 4:
                    // EN: Custom amount: must be between 10 € and 1 000 €
                    // and divisible by 10 (smallest banknote is 10 €).
                    // UA: Довільна сума: має бути від 10 € до 1 000 €
                    // і кратна 10 (найменша купюра – 10 €).
                    Console.WriteLine("Geben Sie einen Betrag zwischen 10,- und 1000,- Euro ein!\n");
                    Console.Write("Betrag: ");
                    betrag = Convert.ToDouble(Console.ReadLine());

                    if (betrag >= 10.0 && betrag <= 1000.0 && betrag % 10 == 0)
                    {
                        Console.WriteLine($"Sie bekommen {betrag:N0},- Euro ausgezahlt.");
                        Console.WriteLine("Wir wünschen Ihnen noch einen schönen Tag.");
                    }
                    else
                    {
                        // EN: Invalid custom amount
                        // UA: Недійсна довільна сума
                        Console.WriteLine("Ungültiger Betrag! Bitte nur Beträge von 10 € bis 1000 € (Vielfache von 10).");
                    }
                    break;

                default:
                    // EN: Menu choice out of range
                    // UA: Вибір меню поза допустимим діапазоном
                    Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl von 1 bis 4 eingeben.");
                    break;
            }

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
