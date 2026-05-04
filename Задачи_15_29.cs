using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер задания (15-29): ");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 15:
                double X = double.Parse(Console.ReadLine());
                int N = int.Parse(Console.ReadLine());
                double sum15 = 0;
                for (int i = 1; i <= N; i++)
                    sum15 += Math.Pow(-1, i - 1) * Math.Pow(X, 2 * i - 1) / (2 * i - 1);
                Console.WriteLine(sum15);
                break;

            case 16:
                double A = double.Parse(Console.ReadLine());
                double B = double.Parse(Console.ReadLine());
                int N16 = int.Parse(Console.ReadLine());

                double H = (B - A) / N16;
                Console.WriteLine("H = " + H);

                for (int i = 0; i <= N16; i++)
                    Console.WriteLine(A + i * H);
                break;

            case 17:
                A = double.Parse(Console.ReadLine());
                B = double.Parse(Console.ReadLine());
                int N17 = int.Parse(Console.ReadLine());

                H = (B - A) / N17;
                for (int i = 0; i <= N17; i++)
                {
                    double x = A + i * H;
                    double f = 1 - Math.Sin(x);
                    Console.WriteLine(f);
                }
                break;

            case 18:
                double D = double.Parse(Console.ReadLine());
                double A1 = 2;
                double A2 = 2;
                int k = 3;

                while (true)
                {
                    double A3 = 1.0 / (A2 - 1);
                    if (Math.Abs(A3 - A2) < D)
                    {
                        Console.WriteLine($"K={k}, A[k-1]={A2}, A[k]={A3}");
                        break;
                    }
                    A2 = A3;
                    k++;
                }
                break;

            case 19:
                D = double.Parse(Console.ReadLine());
                A1 = 1;
                A2 = 2;
                k = 3;

                while (true)
                {
                    double A3 = (A2 + 2 * A1) / 2;
                    if (Math.Abs(A3 - A2) < D)
                    {
                        Console.WriteLine($"K={k}, A[k-1]={A2}, A[k]={A3}");
                        break;
                    }
                    A1 = A2;
                    A2 = A3;
                    k++;
                }
                break;

            case 20:
                int N20 = int.Parse(Console.ReadLine());
                for (int i = 10; i <= N20; i++)
                    if (i % 2 != 0 && i % 5 == 0)
                        Console.Write(i + " ");
                break;

            case 21:
                for (int i = 11; i <= 99; i++)
                    Console.Write(i * i + " ");
                break;

            case 22:
                double x;
                while (true)
                {
                    x = double.Parse(Console.ReadLine());
                    if (x == 0) break;

                    double r;
                    if (x > 0 && x < 3.14)
                        r = Math.Sin(x);
                    else if (x >= -3.14 && x < 0)
                        r = Math.Pow(x, 3);
                    else if (x < -3.14 || x > 3.14)
                        r = x * x;
                    else
                        r = 0;

                    Console.WriteLine(r);
                }
                break;

            case 23:
                int n23 = int.Parse(Console.ReadLine());
                int fact = 1;
                int pow = 1;
                for (int i = 1; i <= n23; i++)
                {
                    fact *= i;
                    pow *= 2;
                }
                Console.WriteLine($"n!={fact}, 2^n={pow}");
                break;

            case 24:
                int N24 = int.Parse(Console.ReadLine());
                int maxDigit = 0;
                while (N24 > 0)
                {
                    int d = N24 % 10;
                    if (d > maxDigit) maxDigit = d;
                    N24 /= 10;
                }
                Console.WriteLine(maxDigit);
                break;

            case 25:
                int N25 = int.Parse(Console.ReadLine());
                int first = N25;
                while (first >= 10) first /= 10;

                int sum25 = 0;
                int temp = N25;
                while (temp > 0)
                {
                    sum25 += temp % 10;
                    temp /= 10;
                }

                Console.WriteLine($"Первая цифра: {first}, Сумма: {sum25}");
                break;

            case 26:
                int N26 = int.Parse(Console.ReadLine());
                int rev = 0, t = N26;
                while (t > 0)
                {
                    rev = rev * 10 + t % 10;
                    t /= 10;
                }
                Console.WriteLine(rev == N26 ? "Палиндром" : "Не палиндром");
                break;

            case 27:
                int sum27 = 0;
                for (int i = 12; i <= 80; i++)
                    sum27 += i * i;
                Console.WriteLine(sum27);
                break;

            case 28:
                for (int i = 22; i <= 88; i++)
                    Console.Write((i * i - (i - 1) * (i - 1)) + " ");
                break;

            case 29:
                double A29 = double.Parse(Console.ReadLine());
                int N29 = int.Parse(Console.ReadLine());
                double sum29 = 0;
                for (int i = 1; i <= N29; i++)
                    sum29 += (A29 * A29 - i * i);
                Console.WriteLine(sum29);
                break;
        }

        Console.ReadKey();
    }
}
