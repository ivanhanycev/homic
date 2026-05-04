using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // 1. Сумма двух чисел
        public static int Task1(int a, int b) => a + b;

        // 2. Разность двух чисел
        public static int Task2(int a, int b) => a - b;

        // 3. Умножение двух чисел
        public static int Task3(int a, int b) => a * b;

        // 4. Деление одного числа на другое (возвращает double)
        public static double Task4(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return a / b;
        }

        // 5. Квадрат числа
        public static double Task5(double a) => a * a;

        // 6. Куб числа
        public static double Task6(double a) => a * a * a;

        // 7. Проверка на четность (возвращает bool)
        public static bool Task7(int a) => a % 2 == 0;

        // 8. Проверка на нечетность
        public static bool Task8(int a) => a % 2 != 0;

        // 9. Максимум из двух чисел
        public static int Task9(int a, int b) => a > b ? a : b;

        // 10. Минимум из двух чисел
        public static int Task10(int a, int b) => a < b ? a : b;

        // 11. Модуль числа (Abs)
        public static int Task11(int a) => a < 0 ? -a : a;

        // 12. Площадь круга по радиусу
        public static double Task12(double radius) => Math.PI * radius * radius;

        // 13. Проверка, является ли число простым
        public static bool Task13(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // 14. Периметр прямоугольника
        public static double Task14(double length, double width) => 2 * (length + width);

        // 15. Перевод градусов Цельсия в Фаренгейты
        public static double Task15(double celsius) => celsius * 9 / 5 + 32;

        // 16. Перевод Фаренгейтов в градусы Цельсия
        public static double Task16(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        // 17. Среднее арифметическое двух чисел
        public static double Task17(double a, double b) => (a + b) / 2;

        // 18. НОД (наибольший общий делитель) двух чисел
        public static int Task18(int a, int b)
        {
            a = Task11(a);
            b = Task11(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // 19. НОК (наименьшее общее кратное)
        public static int Task19(int a, int b)
        {
            return a / Task18(a, b) * b;
        }

        // 20. Проверка, попадает ли число в заданный диапазон [min, max]
        public static bool Task20(int number, int min, int max) => number >= min && number <= max;

        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа № 8");
            Console.WriteLine("Выберите задание - [1] до [20]");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Задание №1 - Сумма двух чисел");
                    Console.Write("Введите число a: ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"a + b = {Task1(a1, b1)}");
                    break;

                case 2:
                    Console.WriteLine("Задание №2 - Разность двух чисел");
                    Console.Write("Введите число a: ");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"a - b = {Task2(a2, b2)}");
                    break;

                case 3:
                    Console.WriteLine("Задание №3 - Умножение двух чисел");
                    Console.Write("Введите число a: ");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"a * b = {Task3(a3, b3)}");
                    break;

                case 4:
                    Console.WriteLine("Задание №4 - Деление двух чисел");
                    Console.Write("Введите число a: ");
                    double a4 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    double b4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"a / b = {Task4(a4, b4)}");
                    break;

                case 5:
                    Console.WriteLine("Задание №5 - Квадрат числа");
                    Console.Write("Введите число: ");
                    double a5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Квадрат числа = {Task5(a5)}");
                    break;

                case 6:
                    Console.WriteLine("Задание №6 - Куб числа");
                    Console.Write("Введите число: ");
                    double a6 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Куб числа = {Task6(a6)}");
                    break;

                case 7:
                    Console.WriteLine("Задание №7 - Проверка на четность");
                    Console.Write("Введите число: ");
                    int a7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Число {a7} четное: {Task7(a7)}");
                    break;

                case 8:
                    Console.WriteLine("Задание №8 - Проверка на нечетность");
                    Console.Write("Введите число: ");
                    int a8 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Число {a8} нечетное: {Task8(a8)}");
                    break;

                case 9:
                    Console.WriteLine("Задание №9 - Максимум из двух чисел");
                    Console.Write("Введите число a: ");
                    int a9 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b9 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Максимум = {Task9(a9, b9)}");
                    break;

                case 10:
                    Console.WriteLine("Задание №10 - Минимум из двух чисел");
                    Console.Write("Введите число a: ");
                    int a10 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b10 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимум = {Task10(a10, b10)}");
                    break;

                case 11:
                    Console.WriteLine("Задание №11 - Модуль числа");
                    Console.Write("Введите число: ");
                    int a11 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"|{a11}| = {Task11(a11)}");
                    break;

                case 12:
                    Console.WriteLine("Задание №12 - Площадь круга");
                    Console.Write("Введите радиус: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Площадь круга = {Task12(radius):F2}");
                    break;

                case 13:
                    Console.WriteLine("Задание №13 - Проверка на простое число");
                    Console.Write("Введите число: ");
                    int a13 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Число {a13} простое: {Task13(a13)}");
                    break;

                case 14:
                    Console.WriteLine("Задание №14 - Периметр прямоугольника");
                    Console.Write("Введите длину: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите ширину: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Периметр = {Task14(length, width)}");
                    break;

                case 15:
                    Console.WriteLine("Задание №15 - Перевод °C в °F");
                    Console.Write("Введите градусы Цельсия: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{celsius}°C = {Task15(celsius):F2}°F");
                    break;

                case 16:
                    Console.WriteLine("Задание №16 - Перевод °F в °C");
                    Console.Write("Введите градусы Фаренгейта: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{fahrenheit}°F = {Task16(fahrenheit):F2}°C");
                    break;

                case 17:
                    Console.WriteLine("Задание №17 - Среднее арифметическое");
                    Console.Write("Введите число a: ");
                    double a17 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    double b17 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Среднее = {Task17(a17, b17)}");
                    break;

                case 18:
                    Console.WriteLine("Задание №18 - НОД двух чисел");
                    Console.Write("Введите число a: ");
                    int a18 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b18 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"НОД({a18}, {b18}) = {Task18(a18, b18)}");
                    break;

                case 19:
                    Console.WriteLine("Задание №19 - НОК двух чисел");
                    Console.Write("Введите число a: ");
                    int a19 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число b: ");
                    int b19 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"НОК({a19}, {b19}) = {Task19(a19, b19)}");
                    break;

                case 20:
                    Console.WriteLine("Задание №20 - Проверка вхождения в диапазон");
                    Console.Write("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите min: ");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите max: ");
                    int max = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Число {number} в диапазоне [{min}, {max}]: {Task20(number, min, max)}");
                    break;

                default:
                    Console.WriteLine("Ошибка ввода данных");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}