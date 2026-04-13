using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("Программа для вычисления формул (1-30)");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        Console.Write("Введите номер задания (1-30): ");
        int task = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (task)
        {
            case 1:
                Console.Write("Введите значение t: ");
                double t = Convert.ToDouble(Console.ReadLine());
                double R = 3 * Math.Pow(t, 2) + 3 * Math.Pow(t, 5) + 4.9;
                Console.WriteLine($"Результат: R = {R}");
                break;

            case 2:
                Console.Write("Введите значение p: ");
                double p2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение y: ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                double K = Math.Log(Math.Pow(p2, 2) + Math.Pow(y2, 3)) + Math.Exp(p2);
                Console.WriteLine($"Результат: K = {K}");
                break;

            case 3:
                Console.Write("Введите значение n: ");
                double n3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение y: ");
                double y3 = Convert.ToDouble(Console.ReadLine());
                double G = n3 * (y3 + 3.5) + Math.Sqrt(y3);
                Console.WriteLine($"Результат: G = {G}");
                break;

            case 4:
                Console.Write("Введите значение a: ");
                double a4 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение t: ");
                double t4 = Convert.ToDouble(Console.ReadLine());
                double D = 9.8 * Math.Pow(a4, 2) + 5.52 * Math.Cos(Math.Pow(t4, 5));
                Console.WriteLine($"Результат: D = {D}");
                break;

            case 5:
                Console.Write("Введите значение x: ");
                double x5 = Convert.ToDouble(Console.ReadLine());
                double L = 1.51 * Math.Cos(Math.Pow(x5, 2)) + 2 * Math.Pow(x5, 3);
                Console.WriteLine($"Результат: L = {L}");
                break;

            case 6:
                Console.Write("Введите значение y: ");
                double y6 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x6 = Convert.ToDouble(Console.ReadLine());
                double M = Math.Cos(2 * y6) + 3.6 * Math.Exp(x6);
                Console.WriteLine($"Результат: M = {M}");
                break;

            case 7:
                Console.Write("Введите значение m: ");
                double m7 = Convert.ToDouble(Console.ReadLine());
                double N7 = Math.Pow(m7, 2) + 2.8 * Math.Abs(m7) + 0.55;
                Console.WriteLine($"Результат: N = {N7}");
                break;

            case 8:
                Console.Write("Введите значение y: ");
                double y8 = Convert.ToDouble(Console.ReadLine());
                double T8 = Math.Sqrt(6 * Math.Pow(y8, 2) - 0.1 * y8 + 4);
                Console.WriteLine($"Результат: T = {T8}");
                break;

            case 9:
                Console.Write("Введите значение y: ");
                double y9 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x9 = Convert.ToDouble(Console.ReadLine());
                double V = Math.Log(y9 + 0.95) + Math.Sin(Math.Pow(x9, 4));
                Console.WriteLine($"Результат: V = {V}");
                break;

            case 10:
                Console.Write("Введите значение y: ");
                double y10 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение k: ");
                double k10 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x10 = Convert.ToDouble(Console.ReadLine());
                double U = Math.Exp(y10) + 7.355 * Math.Pow(k10, 2) + Math.Pow(Math.Sin(x10), 2);
                Console.WriteLine($"Результат: U = {U}");
                break;

            case 11:
                Console.Write("Введите значение y: ");
                double y11 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x11 = Convert.ToDouble(Console.ReadLine());
                double S11 = 9.756 * Math.Pow(y11, 7) + 2 * Math.Tan(x11);
                Console.WriteLine($"Результат: S = {S11}");
                break;

            case 12:
                Console.Write("Введите значение t: ");
                double t12 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x12 = Convert.ToDouble(Console.ReadLine());
                double K12 = 7 * Math.Pow(t12, 2) + 3 * Math.Sin(Math.Pow(x12, 3)) + 9.2;
                Console.WriteLine($"Результат: K = {K12}");
                break;

            case 13:
                Console.Write("Введите значение y: ");
                double y13 = Convert.ToDouble(Console.ReadLine());
                double E = Math.Sqrt(3 * Math.Pow(y13, 2) + 0.5 * y13 + 4);
                Console.WriteLine($"Результат: E = {E}");
                break;

            case 14:
                Console.Write("Введите значение y: ");
                double y14 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x14 = Convert.ToDouble(Console.ReadLine());
                double R14 = Math.Sqrt(Math.Pow(Math.Sin(y14), 2) + 6.835 + Math.Exp(x14));
                Console.WriteLine($"Результат: R = {R14}");
                break;

            case 15:
                Console.Write("Введите значение y: ");
                double y15 = Convert.ToDouble(Console.ReadLine());
                double H = Math.Sin(Math.Pow(y15, 2)) - 2.8 * y15 + Math.Sqrt(Math.Abs(y15));
                Console.WriteLine($"Результат: H = {H}");
                break;

            case 16:
                Console.Write("Введите значение y: ");
                double y16 = Convert.ToDouble(Console.ReadLine());
                double S16 = Math.Sqrt(Math.Cos(4 * Math.Pow(y16, 2)) + 7.151);
                Console.WriteLine($"Результат: S = {S16}");
                break;

            case 17:
                Console.Write("Введите значение y: ");
                double y17 = Convert.ToDouble(Console.ReadLine());
                double N17 = 3 * Math.Pow(y17, 2) + Math.Sqrt(y17 + 1);
                Console.WriteLine($"Результат: N = {N17}");
                break;

            case 18:
                Console.Write("Введите значение y: ");
                double y18 = Convert.ToDouble(Console.ReadLine());
                double Z18 = 3 * Math.Pow(y18, 2) + Math.Sqrt(Math.Pow(y18, 3) + 1);
                Console.WriteLine($"Результат: Z = {Z18}");
                break;

            case 19:
                Console.Write("Введите значение n: ");
                double n19 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение y: ");
                double y19 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение g: ");
                double g19 = Convert.ToDouble(Console.ReadLine());
                double P19 = n19 * Math.Sqrt(Math.Pow(y19, 3) + 1.09 * g19);
                Console.WriteLine($"Результат: P = {P19}");
                break;

            case 20:
                Console.Write("Введите значение k: ");
                double k20 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение y: ");
                double y20 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x20 = Convert.ToDouble(Console.ReadLine());
                double U20 = Math.Exp(k20 + y20) + Math.Tan(x20) * Math.Sqrt(y20);
                Console.WriteLine($"Результат: U = {U20}");
                break;

            case 21:
                Console.Write("Введите значение y: ");
                double y21 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение h: ");
                double h21 = Convert.ToDouble(Console.ReadLine());
                double P21 = Math.Exp(y21 + 5.5) + 9.1 * Math.Pow(h21, 3);
                Console.WriteLine($"Результат: P = {P21}");
                break;

            case 22:
                Console.Write("Введите значение u: ");
                double u22 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение y: ");
                double y22 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x22 = Convert.ToDouble(Console.ReadLine());
                double T22 = Math.Sin(2 * u22) * Math.Log(2 * Math.Pow(y22, 2) + Math.Sqrt(x22));
                Console.WriteLine($"Результат: T = {T22}");
                break;

            case 23:
                Console.Write("Введите значение y: ");
                double y23 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение f: ");
                double f23 = Convert.ToDouble(Console.ReadLine());
                double G23 = Math.Exp(2 * y23) + Math.Sin(f23);
                Console.WriteLine($"Результат: G = {G23}");
                break;

            case 24:
                Console.Write("Введите значение y: ");
                double y24 = Convert.ToDouble(Console.ReadLine());
                double F = 2 * Math.Sin(0.214 * Math.Pow(y24, 3) + 1);
                Console.WriteLine($"Результат: F = {F}");
                break;

            case 25:
                Console.Write("Введите значение y: ");
                double y25 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение f: ");
                double f25 = Convert.ToDouble(Console.ReadLine());
                double G25 = Math.Exp(2 * y25) + Math.Sin(Math.Pow(f25, 2));
                Console.WriteLine($"Результат: G = {G25}");
                break;

            case 26:
                Console.Write("Введите значение p: ");
                double p26 = Convert.ToDouble(Console.ReadLine());
                double Z26 = Math.Sin(Math.Pow(Math.Pow(p26, 2) + 0.4, 3));
                Console.WriteLine($"Результат: Z = {Z26}");
                break;

            case 27:
                Console.Write("Введите значение v: ");
                double v27 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение y: ");
                double y27 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение x: ");
                double x27 = Convert.ToDouble(Console.ReadLine());
                double W27 = 1.03 * v27 + Math.Exp(2 * y27) + Math.Tan(Math.Abs(x27));
                Console.WriteLine($"Результат: W = {W27}");
                break;

            case 28:
                Console.Write("Введите значение y: ");
                double y28 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение h: ");
                double h28 = Convert.ToDouble(Console.ReadLine());
                double T28 = Math.Exp(y28 + h28) + Math.Sqrt(6.4 * y28);
                Console.WriteLine($"Результат: T = {T28}");
                break;

            case 29:
                Console.Write("Введите значение y: ");
                double y29 = Convert.ToDouble(Console.ReadLine());
                double N29 = 3 * Math.Pow(y29, 2) + Math.Sqrt(Math.Abs(y29 + 1));
                Console.WriteLine($"Результат: N = {N29}");
                break;

            case 30:
                Console.Write("Введите значение y: ");
                double y30 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение r: ");
                double r30 = Convert.ToDouble(Console.ReadLine());
                double W30 = Math.Exp(y30 + r30) + 7.2 * Math.Sin(r30);
                Console.WriteLine($"Результат: W = {W30}");
                break;

            default:
                Console.WriteLine("Ошибка: неверный номер задания! Введите число от 1 до 30.");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}