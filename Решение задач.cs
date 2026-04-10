using System;

namespace TasksSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Решение задач ===\n");

            // Задача 4
            Console.WriteLine("--- Задача 4: Прямоугольный треугольник ---");
            Task4_Variant1();
            Task4_Variant2();
            Task4_Variant3();
            Console.WriteLine();

            // Задача 5
            Console.WriteLine("--- Задача 5: Определение сезона ---");
            Task5();
            Console.WriteLine();

            // Задача 6
            Console.WriteLine("--- Задача 6: Увеличение чисел или замена на нули ---");
            Task6_Variant1();
            Task6_Variant2();
            Task6_Variant3();
            Console.WriteLine();

            // Задача 7
            Console.WriteLine("--- Задача 7: Ближайшая к началу координат точка ---");
            Task7_Variant1();
            Task7_Variant2();
            Task7_Variant3();
            Console.WriteLine();

            // Задача 8
            Console.WriteLine("--- Задача 8: Равнобедренный треугольник ---");
            Task8_Variant1();
            Task8_Variant2();
            Task8_Variant3();
            Console.WriteLine();

            // Задача 9
            Console.WriteLine("--- Задача 9: Стоимость разговоров у операторов ---");
            Task9();
            Console.WriteLine();

            // Задача 10
            Console.WriteLine("--- Задача 10: Почтовый автомат ---");
            Task10();
            Console.WriteLine();

            // Задача 11
            Console.WriteLine("--- Задача 11: Смена знака или замена на нули ---");
            Task11_Variant1();
            Task11_Variant2();
            Task11_Variant3();
            Console.WriteLine();

            // Задача 12
            Console.WriteLine("--- Задача 12: Наименьшее из трех чисел ---");
            Task12_Variant1();
            Task12_Variant2();
            Task12_Variant3();
            Console.WriteLine();

            // Задача 13
            Console.WriteLine("--- Задача 13: Числа по модулю больше среднего арифметического ---");
            Task13_Variant1();
            Task13_Variant2();
            Task13_Variant3();
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void Task4_Variant1()
        {
            double a = 3, b = 5, c = -2.1;
            Console.Write($"Вариант 1: a={a}, b={b}, c={c} -> ");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Некорректные стороны (есть отрицательные или нулевые значения)");
                return;
            }

            double a2 = a * a, b2 = b * b, c2 = c * c;
            if (Math.Abs(a2 + b2 - c2) < 0.0001 ||
                Math.Abs(a2 + c2 - b2) < 0.0001 ||
                Math.Abs(b2 + c2 - a2) < 0.0001)
            {
                Console.WriteLine("Является прямоугольным");
            }
            else
            {
                Console.WriteLine("Не является прямоугольным");
            }
        }

        static void Task4_Variant2()
        {
            double a = 21, b = -6.55, c = 0.1;
            Console.Write($"Вариант 2: a={a}, b={b}, c={c} -> ");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Некорректные стороны (есть отрицательные или нулевые значения)");
                return;
            }

            double a2 = a * a, b2 = b * b, c2 = c * c;
            if (Math.Abs(a2 + b2 - c2) < 0.0001 ||
                Math.Abs(a2 + c2 - b2) < 0.0001 ||
                Math.Abs(b2 + c2 - a2) < 0.0001)
            {
                Console.WriteLine("Является прямоугольным");
            }
            else
            {
                Console.WriteLine("Не является прямоугольным");
            }
        }

        static void Task4_Variant3()
        {
            double a = 9, b = 3.7, c = -0.1;
            Console.Write($"Вариант 3: a={a}, b={b}, c={c} -> ");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Некорректные стороны (есть отрицательные или нулевые значения)");
                return;
            }

            double a2 = a * a, b2 = b * b, c2 = c * c;
            if (Math.Abs(a2 + b2 - c2) < 0.0001 ||
                Math.Abs(a2 + c2 - b2) < 0.0001 ||
                Math.Abs(b2 + c2 - a2) < 0.0001)
            {
                Console.WriteLine("Является прямоугольным");
            }
            else
            {
                Console.WriteLine("Не является прямоугольным");
            }
        }

        static void Task5()
        {
            Console.Write("Введите номер месяца (1-12): ");
            int month = int.Parse(Console.ReadLine());

            string season;

            if (month == 12 || month == 1 || month == 2)
            {
                season = "Зима";
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                season = "Весна";
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                season = "Лето";
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                season = "Осень";
            }
            else
            {
                season = "Некорректный номер месяца";
            }

            Console.WriteLine($"Месяц {month} -> {season}");
        }

        static void Task6_Variant1()
        {
            double A = 3, B = 3.5, C = 0.1;
            Console.Write($"Вариант 1: A={A}, B={B}, C={C} -> ");

            if (A + B + C > 0)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
                Console.WriteLine($"Сумма > 0, числа увеличены: A={A}, B={B}, C={C}");
            }
            else
            {
                A = 0;
                B = 0;
                C = 0;
                Console.WriteLine($"Сумма <= 0, числа заменены на нули: A={A}, B={B}, C={C}");
            }
        }

        static void Task6_Variant2()
        {
            double A = 58, B = 27, C = 87;
            Console.Write($"Вариант 2: A={A}, B={B}, C={C} -> ");

            if (A + B + C > 0)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
                Console.WriteLine($"Сумма > 0, числа увеличены: A={A}, B={B}, C={C}");
            }
            else
            {
                A = 0;
                B = 0;
                C = 0;
                Console.WriteLine($"Сумма <= 0, числа заменены на нули: A={A}, B={B}, C={C}");
            }
        }

        static void Task6_Variant3()
        {
            double A = 8, B = 35, C = 42;
            Console.Write($"Вариант 3: A={A}, B={B}, C={C} -> ");

            if (A + B + C > 0)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
                Console.WriteLine($"Сумма > 0, числа увеличены: A={A}, B={B}, C={C}");
            }
            else
            {
                A = 0;
                B = 0;
                C = 0;
                Console.WriteLine($"Сумма <= 0, числа заменены на нули: A={A}, B={B}, C={C}");
            }
        }

        static void Task7_Variant1()
        {
            double x0 = 2, y0 = 2, x1 = 4, y1 = 0;

            double distA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distB = Math.Sqrt(x1 * x1 + y1 * y1);

            Console.Write($"Вариант 1: A({x0},{y0}), B({x1},{y1}) -> ");

            if (Math.Abs(distA - distB) < 0.0001)
            {
                Console.WriteLine($"Точки на одинаковом расстоянии ({distA:F4})");
            }
            else if (distA < distB)
            {
                Console.WriteLine($"Точка A ближе (расстояние {distA:F4} < {distB:F4})");
            }
            else
            {
                Console.WriteLine($"Точка B ближе (расстояние {distB:F4} < {distA:F4})");
            }
        }

        static void Task7_Variant2()
        {
            double x0 = 8, y0 = 9, x1 = 12, y1 = 1;

            double distA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distB = Math.Sqrt(x1 * x1 + y1 * y1);

            Console.Write($"Вариант 2: A({x0},{y0}), B({x1},{y1}) -> ");

            if (Math.Abs(distA - distB) < 0.0001)
            {
                Console.WriteLine($"Точки на одинаковом расстоянии ({distA:F4})");
            }
            else if (distA < distB)
            {
                Console.WriteLine($"Точка A ближе (расстояние {distA:F4} < {distB:F4})");
            }
            else
            {
                Console.WriteLine($"Точка B ближе (расстояние {distB:F4} < {distA:F4})");
            }
        }

        static void Task7_Variant3()
        {
            double x0 = 3.5, y0 = 0.9, x1 = 2, y1 = 3;

            double distA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distB = Math.Sqrt(x1 * x1 + y1 * y1);

            Console.Write($"Вариант 3: A({x0},{y0}), B({x1},{y1}) -> ");

            if (Math.Abs(distA - distB) < 0.0001)
            {
                Console.WriteLine($"Точки на одинаковом расстоянии ({distA:F4})");
            }
            else if (distA < distB)
            {
                Console.WriteLine($"Точка A ближе (расстояние {distA:F4} < {distB:F4})");
            }
            else
            {
                Console.WriteLine($"Точка B ближе (расстояние {distB:F4} < {distA:F4})");
            }
        }

        static void Task8_Variant1()
        {
            double a = 3, b = 3.5, c = 1.1;
            Console.Write($"Вариант 1: a={a}, b={b}, c={c} -> ");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Некорректные стороны");
                return;
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }

            if (Math.Abs(a - b) < 0.0001 || Math.Abs(a - c) < 0.0001 || Math.Abs(b - c) < 0.0001)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }
        }

        static void Task8_Variant2()
        {
            double a = 3, b = 6.55, c = 6.55;
            Console.Write($"Вариант 2: a={a}, b={b}, c={c} -> ");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Некорректные стороны");
                return;
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }

            if (Math.Abs(a - b) < 0.0001 || Math.Abs(a - c) < 0.0001 || Math.Abs(b - c) < 0.0001)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }
        }

        static void Task8_Variant3()
        {
            double a = 0.9, b = 0.9, c = 0.9;
            Console.Write($"Вариант 3: a={a}, b={b}, c={c} -> ");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Некорректные стороны");
                return;
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }

            if (Math.Abs(a - b) < 0.0001 || Math.Abs(a - c) < 0.0001 || Math.Abs(b - c) < 0.0001)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }
        }

        static void Task9()
        {
            Console.Write("Введите количество минут разговора в БУДНИЕ дни: ");
            double weekdayMinutes = double.Parse(Console.ReadLine());

            Console.Write("Введите количество минут разговора в ВЫХОДНЫЕ дни: ");
            double weekendMinutes = double.Parse(Console.ReadLine());

            // Оператор 1: 50 коп = 0.50 руб, скидка 10%
            double cost1 = 0.50;
            int discount1 = 10;
            double weekdayCost1 = weekdayMinutes * cost1;
            double weekendCost1 = weekendMinutes * cost1 * (1 - discount1 / 100.0);
            double totalCost1 = weekdayCost1 + weekendCost1;

            // Оператор 2: 2.45 руб, скидка 8%
            double cost2 = 2.45;
            int discount2 = 8;
            double weekdayCost2 = weekdayMinutes * cost2;
            double weekendCost2 = weekendMinutes * cost2 * (1 - discount2 / 100.0);
            double totalCost2 = weekdayCost2 + weekendCost2;

            // Оператор 3: 3.55 руб, скидка 12%
            double cost3 = 3.55;
            int discount3 = 12;
            double weekdayCost3 = weekdayMinutes * cost3;
            double weekendCost3 = weekendMinutes * cost3 * (1 - discount3 / 100.0);
            double totalCost3 = weekdayCost3 + weekendCost3;

            Console.WriteLine("\nРезультаты:");
            Console.WriteLine($"Оператор 1 (50 коп/мин, скидка {discount1}%): {totalCost1:F2} руб (будни: {weekdayCost1:F2}, выходные: {weekendCost1:F2})");
            Console.WriteLine($"Оператор 2 (2.45 руб/мин, скидка {discount2}%): {totalCost2:F2} руб (будни: {weekdayCost2:F2}, выходные: {weekendCost2:F2})");
            Console.WriteLine($"Оператор 3 (3.55 руб/мин, скидка {discount3}%): {totalCost3:F2} руб (будни: {weekdayCost3:F2}, выходные: {weekendCost3:F2})");
        }

        static void Task10()
        {
            Console.WriteLine("--- Задача 10: Почтовый автомат (автоматическое решение всех вариантов) ---");

            // Вариант 1: Новогодние
            Console.WriteLine("\nВариант 1:");
            int themeNum1 = 1;
            char variant1 = 'c';
            string theme1 = "";
            string variantLetter1 = "";

            if (themeNum1 == 1)
                theme1 = "Новогодние";
            else if (themeNum1 == 2)
                theme1 = "С Днем Рождения";
            else if (themeNum1 == 3)
                theme1 = "С Днем Защитника Отечества";
            else
                theme1 = "неизвестная тема";

            if (variant1 == 'a' || variant1 == 'b' || variant1 == 'c')
                variantLetter1 = variant1.ToString();
            else
                variantLetter1 = "неизвестный вариант";

            if (themeNum1 >= 1 && themeNum1 <= 3 && (variant1 == 'a' || variant1 == 'b' || variant1 == 'c'))
                Console.WriteLine($"  Открытка: {theme1}, вариант {variantLetter1}");
            else
                Console.WriteLine("  Ошибка: неправильный номер темы или вариант!");

            // Вариант 2: С Днем Рождения
            Console.WriteLine("\nВариант 2:");
            int themeNum2 = 2;
            char variant2 = 'a';
            string theme2 = "";
            string variantLetter2 = "";

            if (themeNum2 == 1)
                theme2 = "Новогодние";
            else if (themeNum2 == 2)
                theme2 = "С Днем Рождения";
            else if (themeNum2 == 3)
                theme2 = "С Днем Защитника Отечества";
            else
                theme2 = "неизвестная тема";

            if (variant2 == 'a' || variant2 == 'b' || variant2 == 'c')
                variantLetter2 = variant2.ToString();
            else
                variantLetter2 = "неизвестный вариант";

            if (themeNum2 >= 1 && themeNum2 <= 3 && (variant2 == 'a' || variant2 == 'b' || variant2 == 'c'))
                Console.WriteLine($"  Открытка: {theme2}, вариант {variantLetter2}");
            else
                Console.WriteLine("  Ошибка: неправильный номер темы или вариант!");

            // Вариант 3: С Днем Защитника Отечества
            Console.WriteLine("\nВариант 3:");
            int themeNum3 = 3;
            char variant3 = 'b';
            string theme3 = "";
            string variantLetter3 = "";

            if (themeNum3 == 1)
                theme3 = "Новогодние";
            else if (themeNum3 == 2)
                theme3 = "С Днем Рождения";
            else if (themeNum3 == 3)
                theme3 = "С Днем Защитника Отечества";
            else
                theme3 = "неизвестная тема";

            if (variant3 == 'a' || variant3 == 'b' || variant3 == 'c')
                variantLetter3 = variant3.ToString();
            else
                variantLetter3 = "неизвестный вариант";

            if (themeNum3 >= 1 && themeNum3 <= 3 && (variant3 == 'a' || variant3 == 'b' || variant3 == 'c'))
                Console.WriteLine($"  Открытка: {theme3}, вариант {variantLetter3}");
            else
                Console.WriteLine("  Ошибка: неправильный номер темы или вариант!");

            // Дополнительно: проверка обработки неправильного ввода
            Console.WriteLine("\n--- Проверка обработки ошибок ---");
            Console.WriteLine("\nНеправильный номер темы (4):");
            int themeNumError = 4;
            char variantError = 'a';
            string themeError = "";
            string variantLetterError = "";

            if (themeNumError == 1)
                themeError = "Новогодние";
            else if (themeNumError == 2)
                themeError = "С Днем Рождения";
            else if (themeNumError == 3)
                themeError = "С Днем Защитника Отечества";
            else
                themeError = "неизвестная тема";

            if (variantError == 'a' || variantError == 'b' || variantError == 'c')
                variantLetterError = variantError.ToString();
            else
                variantLetterError = "неизвестный вариант";

            if (themeNumError >= 1 && themeNumError <= 3 && (variantError == 'a' || variantError == 'b' || variantError == 'c'))
                Console.WriteLine($"  Открытка: {themeError}, вариант {variantLetterError}");
            else
                Console.WriteLine("  Ошибка: неправильный номер темы или вариант!");

            Console.WriteLine("\nНеправильный вариант (d):");
            int themeNumError2 = 2;
            char variantError2 = 'd';
            string themeError2 = "";
            string variantLetterError2 = "";

            if (themeNumError2 == 1)
                themeError2 = "Новогодние";
            else if (themeNumError2 == 2)
                themeError2 = "С Днем Рождения";
            else if (themeNumError2 == 3)
                themeError2 = "С Днем Защитника Отечества";
            else
                themeError2 = "неизвестная тема";

            if (variantError2 == 'a' || variantError2 == 'b' || variantError2 == 'c')
                variantLetterError2 = variantError2.ToString();
            else
                variantLetterError2 = "неизвестный вариант";

            if (themeNumError2 >= 1 && themeNumError2 <= 3 && (variantError2 == 'a' || variantError2 == 'b' || variantError2 == 'c'))
                Console.WriteLine($"  Открытка: {themeError2}, вариант {variantLetterError2}");
            else
                Console.WriteLine("  Ошибка: неправильный номер темы или вариант!");
        }


        static void Task11_Variant1()
        {
            double a = 3, b = 3.5;
            Console.Write($"Вариант 1: a={a}, b={b} -> ");

            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                a = -a;
                b = -b;
                Console.WriteLine($"Разные знаки -> меняем знак: a={a}, b={b}");
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($"Одинаковые знаки -> заменяем на нули: a={a}, b={b}");
            }
        }

        static void Task11_Variant2()
        {
            double a = 5.8, b = 2.7;
            Console.Write($"Вариант 2: a={a}, b={b} -> ");

            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                a = -a;
                b = -b;
                Console.WriteLine($"Разные знаки -> меняем знак: a={a}, b={b}");
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($"Одинаковые знаки -> заменяем на нули: a={a}, b={b}");
            }
        }

        static void Task11_Variant3()
        {
            double a = 8, b = 3.5;
            Console.Write($"Вариант 3: a={a}, b={b} -> ");

            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                a = -a;
                b = -b;
                Console.WriteLine($"Разные знаки -> меняем знак: a={a}, b={b}");
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($"Одинаковые знаки -> заменяем на нули: a={a}, b={b}");
            }
        }

        static void Task12_Variant1()
        {
            int a = 45, b = 13, c = -23;
            int min;

            if (a <= b && a <= c)
            {
                min = a;
            }
            else if (b <= a && b <= c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            Console.WriteLine($"Вариант 1: числа {a}, {b}, {c} -> наименьшее = {min}");
        }

        static void Task12_Variant2()
        {
            int a = 31, b = 65, c = 12;
            int min;

            if (a <= b && a <= c)
            {
                min = a;
            }
            else if (b <= a && b <= c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            Console.WriteLine($"Вариант 2: числа {a}, {b}, {c} -> наименьшее = {min}");
        }

        static void Task12_Variant3()
        {
            int a = 52, b = -1, c = -33;
            int min;

            if (a <= b && a <= c)
            {
                min = a;
            }
            else if (b <= a && b <= c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            Console.WriteLine($"Вариант 3: числа {a}, {b}, {c} -> наименьшее = {min}");
        }

        static void Task13_Variant1()
        {
            double x = 3.2, y = 7, z = 0.5;

            double absX = Math.Abs(x);
            double absY = Math.Abs(y);
            double absZ = Math.Abs(z);

            double avg = (absX + absY + absZ) / 3;

            Console.WriteLine($"Вариант 1: x={x}, y={y}, z={z}");
            Console.WriteLine($"  Среднее арифметическое модулей = {avg:F4}");
            Console.Write("  Числа, чей модуль больше среднего: ");

            if (absX > avg)
            {
                Console.Write($"x={x} ");
            }
            if (absY > avg)
            {
                Console.Write($"y={y} ");
            }
            if (absZ > avg)
            {
                Console.Write($"z={z} ");
            }
            if (absX <= avg && absY <= avg && absZ <= avg)
            {
                Console.Write("нет таких чисел");
            }
            Console.WriteLine();
        }

        static void Task13_Variant2()
        {
            double x = 2.3, y = 3, z = 2.5;

            double absX = Math.Abs(x);
            double absY = Math.Abs(y);
            double absZ = Math.Abs(z);

            double avg = (absX + absY + absZ) / 3;

            Console.WriteLine($"Вариант 2: x={x}, y={y}, z={z}");
            Console.WriteLine($"  Среднее арифметическое модулей = {avg:F4}");
            Console.Write("  Числа, чей модуль больше среднего: ");

            if (absX > avg)
            {
                Console.Write($"x={x} ");
            }
            if (absY > avg)
            {
                Console.Write($"y={y} ");
            }
            if (absZ > avg)
            {
                Console.Write($"z={z} ");
            }
            if (absX <= avg && absY <= avg && absZ <= avg)
            {
                Console.Write("нет таких чисел");
            }
            Console.WriteLine();
        }

        static void Task13_Variant3()
        {
            double x = 23, y = -34, z = 89.5;

            double absX = Math.Abs(x);
            double absY = Math.Abs(y);
            double absZ = Math.Abs(z);

            double avg = (absX + absY + absZ) / 3;

            Console.WriteLine($"Вариант 3: x={x}, y={y}, z={z}");
            Console.WriteLine($"  Среднее арифметическое модулей = {avg:F4}");
            Console.Write("  Числа, чей модуль больше среднего: ");

            if (absX > avg)
            {
                Console.Write($"x={x} ");
            }
            if (absY > avg)
            {
                Console.Write($"y={y} ");
            }
            if (absZ > avg)
            {
                Console.Write($"z={z} ");
            }
            if (absX <= avg && absY <= avg && absZ <= avg)
            {
                Console.Write("нет таких чисел");
            }
            Console.WriteLine();
        }
    }
}