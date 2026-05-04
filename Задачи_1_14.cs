using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер задания (1-14): ");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = A; i <= B; i++)
                {
                    Console.Write(i + " ");
                    count++;
                }
                Console.WriteLine("\nКоличество: " + count);
                break;

            case 2:
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                count = 0;
                for (int i = B - 1; i > A; i--)
                {
                    Console.Write(i + " ");
                    count++;
                }
                Console.WriteLine("\nКоличество: " + count);
                break;

            case 3:
                double a = double.Parse(Console.ReadLine());
                int N = int.Parse(Console.ReadLine());
                double res = 1;
                for (int i = 0; i < N; i++) res *= a;
                Console.WriteLine(res);
                break;

            case 4:
                a = double.Parse(Console.ReadLine());
                N = int.Parse(Console.ReadLine());
                double p = 1;
                for (int i = 1; i <= N; i++)
                {
                    p *= a;
                    Console.WriteLine(p);
                }
                break;

            case 5:
                a = double.Parse(Console.ReadLine());
                N = int.Parse(Console.ReadLine());
                double sum = 1, power = 1;
                for (int i = 1; i <= N; i++)
                {
                    power *= a;
                    sum += power;
                }
                Console.WriteLine(sum);
                break;

            case 6:
                N = int.Parse(Console.ReadLine());
                int k = 1;
                while (3 * k <= N) k++;
                Console.WriteLine($"K={k}, 3K={3 * k}");
                break;

            case 7:
                N = int.Parse(Console.ReadLine());
                k = 1;
                while (3 * k < N) k++;
                k--;
                Console.WriteLine($"K={k}, 3K={3 * k}");
                break;

            case 8:
                double A8 = double.Parse(Console.ReadLine());
                double s = 0;
                int n8 = 0;
                while (s <= A8)
                {
                    n8++;
                    s += 1.0 / n8;
                }
                Console.WriteLine($"N={n8}, Sum={s}");
                break;

            case 9:
                N = int.Parse(Console.ReadLine());
                double fact = 1;
                for (int i = 1; i <= N; i++) fact *= i;
                Console.WriteLine(fact);
                break;

            case 10:
                N = int.Parse(Console.ReadLine());
                double prod = 1;
                for (int i = 1; i <= N; i++) prod *= (1.0 / i);
                Console.WriteLine(2 * prod);
                break;

            case 11:
                double X = double.Parse(Console.ReadLine());
                N = int.Parse(Console.ReadLine());
                double sum11 = 1;
                for (int i = 1; i <= N; i++)
                    sum11 += Math.Pow(X, i) / i;
                Console.WriteLine(sum11);
                break;

            case 12:
                X = double.Parse(Console.ReadLine());
                N = int.Parse(Console.ReadLine());
                double sum12 = 0;
                for (int i = 1; i <= N; i++)
                    sum12 += Math.Pow(-1, i + 1) * Math.Pow(X, 2 * i - 1) / (2 * i - 1);
                Console.WriteLine(sum12);
                break;

            case 13:
                X = double.Parse(Console.ReadLine());
                N = int.Parse(Console.ReadLine());
                double sum13 = 1;
                for (int i = 1; i <= N; i++)
                    sum13 += Math.Pow(-1, i) * Math.Pow(X, 2 * i) / (2 * i);
                Console.WriteLine(sum13);
                break;

            case 14:
                X = double.Parse(Console.ReadLine());
                N = int.Parse(Console.ReadLine());
                double sum14 = 0;
                for (int i = 1; i <= N; i++)
                    sum14 += Math.Pow(-1, i - 1) * Math.Pow(X, i) / i;
                Console.WriteLine(sum14);
                break;
        }

        Console.ReadKey();
    }
}
