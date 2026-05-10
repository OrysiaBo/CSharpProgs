using System;

// EN: Aufgabe 1 – Shipping cost calculator
//     A company delivers free of charge for orders >= 100 €.
//     Orders below 100 € incur a flat shipping fee of 6.50 €.
//
// UA: Завдання 1 – Калькулятор вартості доставки
//     Компанія доставляє безкоштовно при замовленні від 100 €.
//     При замовленнях менше 100 € стягується фіксований збір 6,50 €.

namespace Aufgabe01_Versandkosten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aufgabe 1 – Versandkosten";

            // EN: Prompt the user to enter the order value
            // UA: Запитуємо у користувача суму замовлення
            Console.Write("Bestellwert in Euro: ");
            double bestellwert = Convert.ToDouble(Console.ReadLine());

            double rechnungsbetrag;

            // EN: If the order is >= 100 €, no shipping is added;
            //     otherwise add the 6.50 € shipping flat fee.
            // UA: Якщо замовлення >= 100 €, доставка безкоштовна;
            //     інакше додаємо фіксовану вартість доставки 6,50 €.
            if (bestellwert >= 100.0)
            {
                rechnungsbetrag = bestellwert;
            }
            else
            {
                rechnungsbetrag = bestellwert + 6.50;
            }

            // EN: Display the resulting invoice amount
            // UA: Виводимо суму рахунку
            Console.WriteLine($"Rechnungsbetrag: {rechnungsbetrag:F2} Euro");

            Console.WriteLine("\nZum Beenden drücken Sie eine beliebige Taste ...");
            Console.ReadKey();
        }
    }
}
