using System;

namespace Distance
{
    class Distancee
    {
        public struct Distance
        {
            public int foot;
            public int inch;
            public void Display()
            {
                Console.WriteLine("{0} ' - {1} \"", this.foot, this.inch);
            }
            public static Distance AddDist(Distance a, Distance b)
            {
                Distance c;
                c.foot = a.foot + b.foot;
                c.inch = a.inch + b.inch;
                c.foot += c.inch / 12;
                c.inch %= 12;
                return c;
                
            }
        }
        static void Main(string[] args)
        {
            Distance a, b, c;
            Console.WriteLine("Введите количество футов для первой переменной: ");
            a.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество дюймов для первой переменной: ");
            a.inch = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество футов для второй переменной: ");
            b.foot = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество дюймов для второй переменной: ");
            b.inch = int.Parse(Console.ReadLine());
            c = Distance.AddDist(a, b);
            Console.WriteLine("Значение первой переменной : ");
            a.Display();
            Console.WriteLine("Значение второй переменной :");
            b.Display();
            Console.WriteLine("Значение третьей переменной :");
            c.Display();

        }
    }
}
