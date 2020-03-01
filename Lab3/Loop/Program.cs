using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());

            ////while:
            //Console.Write("\nwhile: \t\t");
            //int i = 1;
            //while (i<=n)
            //{
            //    Console.Write(" " + i);
            //    i += 2;
            //}

            ////do while:
            //Console.Write("\ndo while: \t");
            //i = 1;
            //do
            //{
            //    Console.Write(" " + i);
            //    i += 2;
            //}
            //while (i <= n);

            //// for:
            //Console.Write("\nFor: \t\t");
            //for (i = 1; i <= n; i += 2)
            //{
            //    Console.Write(" " + i);
            //}

            ////цикл с постусловием, вычисление синуса на интервале
            //double x, x1, x2, y;
            //Console.Write("Введите нижнюю границу интервала: ");
            //x1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите верхнюю границу интервала: ");
            //x2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("\tx\tsin(x)");
            //x = x1;
            //do
            //{
            //    y = Math.Sin(x);
            //    Console.WriteLine("\t{0}\t{1:0.00000}", x, y);
            //x = x + 0.01;
            //}
            //while (x <= x2);

            //цикл с предусловием, алгоритм Евклида
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            while(temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }

            Console.WriteLine("НОД = {0}", temp);
        }
    }
    }

