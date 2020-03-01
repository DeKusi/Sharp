using System;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////цикл с постусловием, вычисление синуса на интервале
            //double x, x1, x2, y;
            //Console.Write("Введите нижнюю границу интервала: ");
            //x1 = double.Parse(Console.ReadLine());
            //Console.Write("Введите верхнюю границу интервала: ");
            //x2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("\tx\tsin(x)");
            //x = x1;

            //while (x <= x2) 
            //{
            //    y = Math.Sin(x);
            //    Console.WriteLine("\t{0}\t{1:0.00000}", x, y);
            //    x += 0.01;
            //}


            //цикл с предусловием, алгоритм Евклида
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            do
            {
                a = temp;
                if (a == b) break;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            while (temp != b);

            Console.WriteLine("НОД = {0}", temp);
        }
    }
}
