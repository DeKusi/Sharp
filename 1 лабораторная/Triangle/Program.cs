using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter perimetr value");
                double p = double.Parse(Console.ReadLine());
                double a = p / 3;
                p = p / 2;
                double s = Math.Sqrt(p * Math.Pow(p - a, 3));
                Console.WriteLine("Сторона\tПлощадь");
                Console.WriteLine("{0:0.00}\t{1:0.00}", a, s);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}", e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An DivideByZero exception was thrown: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
