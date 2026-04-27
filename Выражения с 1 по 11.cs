using System;

namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = true, B = false, C = false;
            int X = 0, Y = 1, Z = 0;

            Console.WriteLine((A || !A && B) || C);
            Console.WriteLine(!A || A && (B || C));
            Console.WriteLine((A || B && !C) && C);

            Console.WriteLine(X != 0 && !(Z != 0 || Y != 0) || Z == 0);
            Console.WriteLine(X == 0 || X != 0 && (Y != 0 || Z != 0));
            Console.WriteLine((X != 0 || Y != 0 && Z == 0) && Z != 0);

            int x = 2, y = 1;
            Console.WriteLine((!(x * y < 0)) && (y > x));

            x = 2; y = -2;
            Console.WriteLine((x >= 2) || (y * y != 5));

            int A1 = 6;
            Console.WriteLine(A1 % 2 == 0 || A1 % 3 == 0);

            int A2 = 5, B2 = 7;
            Console.WriteLine(A2 % 2 != 0 && B2 % 2 != 0);

            X = 0; Y = 0; Z = 1;
            Console.WriteLine(X != 0 || Y != 0 && Z == 0);
            Console.WriteLine(X == 0 && Y == 0);
            Console.WriteLine(!(X != 0 && Z != 0) || Y != 0);

            Console.WriteLine("y = 2tg(x), x ≠ π/2 + πk");
            Console.WriteLine("y = 3/(x-1), x ≠ 1");

            x = 1; y = 2;
            Console.WriteLine((x >= 0) && (y * y == 4));

            x = 2; y = 1;
            Console.WriteLine((x * y != 0) || (y > x));

            x = 1; y = 2;
            Console.WriteLine(!(x * y < 0) || (y > x));

            x = 2; y = 1;
            Console.WriteLine((x * y != 0) && (y < x));

            A = true; B = false; C = true;
            Console.WriteLine(A || !(A && B) || C);
            Console.WriteLine(!A || C && !(B || C));
            Console.WriteLine((A || B && !C) || A);

            x = 1; y = 2;
            Console.WriteLine(!(x * y < 1) && (y > x));
        }
    }
}
