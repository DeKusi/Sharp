using System;

namespace Shapeifelse
{
    class _switch
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("введите требуемый операнд ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("B = ");
            float b = float.Parse(Console.ReadLine());

            bool ok = true;
            double res = 0;

            switch (op)
            {
                case '+':
                    res = a + b; 
                    break;
                case '-': 
                    res = a - b; 
                    break;
                case '*': 
                    res = a * b; 
                    break;
                case '/':
                case ':':
                        res = a / b;
                    break;
                default:
                    ok = false;
                    break;
            }

            if (ok) Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);
            else Console.WriteLine("Операция не определена");

        }
    }
}
