using System;

class Aufgabe3_MillionEuro
{
    static void Main_Aufgabe3()
    {
        // Початковий виграш у лотерею (в євро)
        // Initial lottery winnings (in euros)
        double kapital = 1_000_000.0; // 1 000 000 євро / 1,000,000 euros

        // Змінна для зберігання річної процентної ставки (у відсотках)
        // Variable to store the annual interest rate (in percent)
        double zinssatz;

        // Змінна для зберігання щорічного "зарплатного" виплату
        // Variable to store the annual "salary" withdrawal
        double gehalt;

        // Лічильник років
        // Year counter
        int jahre = 0;

        // Максимальна кількість років (захист від нескінченного циклу)
        // Maximum number of years (protection against infinite loop)
        const int MAX_JAHRE = 100;

        // Вивід заголовку програми
        // Output of the program title
        Console.WriteLine("=== Калькулятор лотерейного виграшу: 1 000 000 євро ===");
        Console.WriteLine("=== Lottery Winnings Calculator: 1,000,000 Euros ===");
        Console.WriteLine();

        // Запит та введення річної процентної ставки
        // Request and input of the annual interest rate
        Console.Write("Введіть річну процентну ставку (у %): ");
        Console.Write("Enter the annual interest rate (in %): ");
        string zinssatzStr = Console.ReadLine();

        // Перевірка коректності введення процентної ставки
        // Validation of the interest rate input
        while (!double.TryParse(zinssatzStr,
            System.Globalization.NumberStyles.Any,
            System.Globalization.CultureInfo.InvariantCulture,
            out zinssatz) || zinssatz < 0)
        {
            Console.WriteLine("Помилка: введіть невід'ємне число! / Error: enter a non-negative number!");
            Console.Write("Введіть річну процентну ставку (у %): / Enter annual interest rate (in %): ");
            zinssatzStr = Console.ReadLine();
        }

        Console.WriteLine();

        // Запит та введення щорічного "зарплатного" виплату
        // Request and input of the annual "salary" withdrawal
        Console.Write("Введіть бажану річну 'зарплату' (у євро): ");
        Console.Write("Enter the desired annual 'salary' (in euros): ");
        string gehaltStr = Console.ReadLine();

        // Перевірка коректності введення суми зарплати
        // Validation of the salary amount input
        while (!double.TryParse(gehaltStr,
            System.Globalization.NumberStyles.Any,
            System.Globalization.CultureInfo.InvariantCulture,
            out gehalt) || gehalt <= 0)
        {
            Console.WriteLine("Помилка: введіть позитивне число! / Error: enter a positive number!");
            Console.Write("Введіть бажану річну 'зарплату' (у євро): / Enter desired annual 'salary' (in euros): ");
            gehaltStr = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine($"Початковий капітал / Initial capital: {kapital:F2} €");
        Console.WriteLine($"Процентна ставка / Interest rate: {zinssatz} %");
        Console.WriteLine($"Щорічна 'зарплата' / Annual 'salary': {gehalt:F2} €");
        Console.WriteLine();
        Console.WriteLine("─────────────────────────────────────────────────────────");
        Console.WriteLine($"{"Рік/Year",-10} {"Відсотки/Interest",-22} {"Після відсотків/After interest",-32} {"Залишок/Balance",-20}");
        Console.WriteLine("─────────────────────────────────────────────────────────");

        // STRUKTOGRAMM (Struktogram):
        // ┌──────────────────────────────────────────────────────────────────┐
        // │ kapital = 1000000, jahre = 0                                     │
        // │ Ввести zinssatz та gehalt / Enter zinssatz and gehalt            │
        // ├──────────────────────────────────────────────────────────────────┤
        // │ WHILE kapital > 0 AND jahre < 100                                │
        // │ ┌────────────────────────────────────────────────────────────┐   │
        // │ │ jahre = jahre + 1                                          │   │
        // │ │ zinsen = kapital * zinssatz / 100                          │   │
        // │ │ kapital = kapital + zinsen                                 │   │
        // │ │ kapital = kapital - gehalt                                 │   │
        // │ │ Вивести рік, відсотки, залишок                             │   │
        // │ │ Print year, interest, balance                              │   │
        // │ │ IF kapital <= 0: вивести "Кошти вичерпано"                 │   │
        // │ │ IF kapital <= 0: print "Funds exhausted"                  │   │
        // │ └────────────────────────────────────────────────────────────┘   │
        // │ Вивести кількість років / Print number of years                  │
        // │ IF jahre == 100: вивести попередження / print warning            │
        // └──────────────────────────────────────────────────────────────────┘

        // Цикл while: виконується поки капітал більший за 0 І не досягнуто 100 років
        // While loop: runs while capital is greater than 0 AND 100 years have not been reached
        while (kapital > 0 && jahre < MAX_JAHRE)
        {
            // Збільшуємо лічильник років на 1 (новий рік починається)
            // Increment the year counter by 1 (a new year begins)
            jahre++;

            // Обчислюємо суму річних відсотків: капітал * ставка / 100
            // Calculate the annual interest amount: capital * rate / 100
            double zinsen = kapital * zinssatz / 100.0;

            // Нараховуємо відсотки до капіталу (капітал зростає)
            // Add interest to capital (capital grows)
            kapital += zinsen; // еквівалентно: kapital = kapital + zinsen

            // Зберігаємо капітал після нарахування відсотків для відображення
            // Save capital after interest accrual for display
            double kapitalNachZinsen = kapital;

            // Знімаємо щорічну "зарплату" з капіталу
            // Deduct the annual "salary" from capital
            kapital -= gehalt; // еквівалентно: kapital = kapital - gehalt

            // Виводимо інформацію по поточному році
            // Print information for the current year
            Console.WriteLine($"{jahre,-10} {zinsen,-22:F2} {kapitalNachZinsen,-32:F2} {Math.Max(0, kapital),-20:F2} €");

            // Якщо після виплати "зарплати" капітал вичерпано або став від'ємним -
            // виводимо відповідне повідомлення (цикл завершиться сам на наступній перевірці умови)
            // If after paying the "salary" the capital is exhausted or became negative -
            // print a corresponding message (the loop will end itself on the next condition check)
            if (kapital <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("  → Кошти вичерпано! / Funds exhausted!");
            }
        }

        Console.WriteLine("─────────────────────────────────────────────────────────");
        Console.WriteLine();

        // Виводимо підсумковий результат: кількість років
        // Print the final result: number of years
        Console.WriteLine($"✓ Від виграшу можна прожити / You can live from the winnings for: {jahre} років / years");

        // Перевірка: якщо досягнуто межі 100 років - виводимо попередження
        // Check: if the 100-year limit has been reached - print a warning
        if (jahre >= MAX_JAHRE && kapital > 0)
        {
            Console.WriteLine();
            Console.WriteLine("⚠ УВАГА: Досягнуто межі 100 років! Капітал ще не вичерпано.");
            Console.WriteLine("⚠ WARNING: 100-year limit reached! Capital is not yet exhausted.");
            Console.WriteLine($"   Залишок капіталу / Remaining capital: {kapital:F2} €");
        }
    }
}

