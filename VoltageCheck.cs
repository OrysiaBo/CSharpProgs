using System;

class Aufgabe1_Spannungspruefung
{
    static void Main_Aufgabe1()
    {
        // Оголошення змінної для зберігання введеного значення напруги
        // Declaration of a variable to store the entered voltage value
        double spannung;

        // Константи для меж допустимого діапазону напруги
        // Constants for the boundaries of the valid voltage range
        const double MIN_SPANNUNG = 14.9; // Мінімальна допустима напруга / Minimum valid voltage
        const double MAX_SPANNUNG = 15.1; // Максимальна допустима напруга / Maximum valid voltage

        // Вивід заголовку програми
        // Output of the program title
        Console.WriteLine("=== Перевірка напруги операційного підсилювача ===");
        Console.WriteLine("=== Voltage Check for Operational Amplifier ===");
        Console.WriteLine();

        spannung = 0;

        // Умова продовження циклу: поки напруга НЕ знаходиться в допустимому діапазоні
        // Loop continuation condition: while voltage is NOT within the valid range
        while (spannung < MIN_SPANNUNG || spannung > MAX_SPANNUNG)
        {
            // Запит до користувача ввести значення напруги
            // Prompt the user to enter a voltage value
            Console.Write($"Введіть напругу (допустимий діапазон: {MIN_SPANNUNG} В - {MAX_SPANNUNG} В): ");
            Console.Write($"Enter voltage (valid range: {MIN_SPANNUNG} V - {MAX_SPANNUNG} V): ");

            // Зчитування введеного значення та конвертація у тип double
            // Reading the entered value and converting to double type
            // Використовуємо InvariantCulture для коректного розпізнавання десяткової крапки
            // Using InvariantCulture for correct recognition of decimal point
            string eingabe = Console.ReadLine();
            if (!double.TryParse(eingabe,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out spannung))
            {
                // Якщо введено нечислове значення - встановлюємо неприпустиме значення
                // If non-numeric value entered - set an invalid value
                spannung = 0;
                Console.WriteLine("Помилка: введіть числове значення! / Error: please enter a numeric value!");
                continue;
            }

            // Перевіряємо, чи знаходиться введена напруга поза допустимим діапазоном
            // Check whether the entered voltage is outside the valid range
            if (spannung < MIN_SPANNUNG || spannung > MAX_SPANNUNG)
            {
                // Повідомлення про те, що значення не відповідає вимогам
                // Message that the value does not meet the requirements
                Console.WriteLine($"ПОМИЛКА: Напруга {spannung} В виходить за межі допустимого діапазону!");
                Console.WriteLine($"ERROR: Voltage {spannung} V is outside the valid range!");
                Console.WriteLine($"Допустимий діапазон / Valid range: {MIN_SPANNUNG} В - {MAX_SPANNUNG} В");
                Console.WriteLine();
            }
        }

        // Повідомлення про успішне введення напруги в допустимому діапазоні
        // Message about successful voltage entry within the valid range
        Console.WriteLine();
        Console.WriteLine($"✓ Напруга {spannung} В знаходиться у допустимому діапазоні. Перевірку пройдено!");
        Console.WriteLine($"✓ Voltage {spannung} V is within the valid range. Check passed!");
    }
}


