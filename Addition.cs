using System;
class Aufgabe2_Addition
{
    static void Main_Aufgabe2()
    {
        // Змінна для зберігання поточно введеного числа (згідно умови - називається "eingabe")
        // Variable to store the currently entered number (as required - named "eingabe")
        int eingabe;

        // Змінна для накопичення суми всіх введених чисел
        // Variable to accumulate the sum of all entered numbers
        int summe = 0;

        // Лічильник кількості введених чисел
        // Counter for the number of entered numbers
        int anzahl = 0;

        // Вивід заголовку програми
        // Output of the program title
        Console.WriteLine("=== Додавання цілих чисел до перевищення 100 ===");
        Console.WriteLine("=== Addition of integers until sum exceeds 100 ===");
        Console.WriteLine();

        // STRUKTOGRAMM (Struktogram):
        // ┌────────────────────────────────────────────────────┐
        // │ summe = 0, anzahl = 0                              │
        // ├────────────────────────────────────────────────────┤
        // │ WHILE summe <= 100                                 │
        // │ ┌──────────────────────────────────────────────┐   │
        // │ │ Вивести запит / Print prompt                 │   │
        // │ │ Зчитати eingabe / Read eingabe               │   │
        // │ │ summe = summe + eingabe                      │   │
        // │ │ anzahl = anzahl + 1                          │   │
        // │ │ Вивести поточну суму / Print current sum     │   │
        // │ └──────────────────────────────────────────────┘   │
        // │ Вивести anzahl / Print anzahl                       │
        // └────────────────────────────────────────────────────┘

        // Цикл while: виконується поки сума НЕ перевищує 100
        // While loop: runs while the sum does NOT exceed 100
        while (summe <= 100)
        {
            // Запит до користувача ввести ціле число
            // Prompt the user to enter an integer
            Console.Write($"Введіть ціле число (поточна сума: {summe}): ");
            Console.Write($"Enter an integer (current sum: {summe}): ");

            // Зчитування введеного числа
            // Reading the entered number
            string eingabeStr = Console.ReadLine();
            if (!int.TryParse(eingabeStr, out eingabe))
            {
                // Якщо введено нечислове значення - пропускаємо ітерацію
                // If non-integer value entered - skip this iteration
                Console.WriteLine("Помилка: введіть ціле число! / Error: please enter an integer!");
                continue;
            }

            // Додаємо введене число до суми
            // Add the entered number to the sum
            summe += eingabe; // еквівалентно: summe = summe + eingabe / equivalent to: summe = summe + eingabe

            // Збільшуємо лічильник кількості доданих чисел на 1
            // Increment the counter of added numbers by 1
            anzahl++; // еквівалентно: anzahl = anzahl + 1 / equivalent to: anzahl = anzahl + 1

            // Виводимо поточний стан суми після додавання
            // Print the current state of the sum after addition
            Console.WriteLine($"  Додано: {eingabe} | Поточна сума: {summe}");
            Console.WriteLine($"  Added: {eingabe} | Current sum: {summe}");
            Console.WriteLine();
        }

        // Виводимо фінальний результат: кількість доданих чисел та підсумкову суму
        // Print the final result: number of added numbers and the final sum
        Console.WriteLine("─────────────────────────────────────────────");
        Console.WriteLine($"✓ Сума {summe} перевищила 100!");
        Console.WriteLine($"✓ Sum {summe} has exceeded 100!");
        Console.WriteLine($"✓ Кількість доданих чисел / Number of added numbers: {anzahl}");
    }
}


