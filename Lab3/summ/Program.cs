using System;

namespace summ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа считает сумму чисел от 1 до k и от m до 100");
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int s = 0;

            for (int i = 1; i<=100; i++)
            {
                if (i < m && i > k) continue;
                s += i;
            }
            Console.WriteLine("Сумма чисел равна {0}", s);
        }
    }
}
