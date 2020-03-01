using System;

namespace Tatget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько выстрелов вы хотите сделать? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("В каком режиме вы хотите стрелять?\n1) Обычный\n2) Стрельба в слепую\n3) Стрельба с помехой");

            char r =char.Parse( Console.ReadLine());
            
            int[,] arr = new int[n,2];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Выстрел {0}: ", i + 1);
                Console.Write("\tx = ");
                arr[i, 0] = int.Parse(Console.ReadLine());

                Console.Write("\ty = ");
                arr[i, 1] = int.Parse(Console.ReadLine());
            }

            //Сумма баллов
            int s = 0;
            
            //Подсчёт результатов в зависимости от выбранного режима
            switch (r)
            {
                case '1':
                    {
                        for (int i = 0; i<n; i++)
                        {
                            if (arr[i, 0] * arr[i, 0] + arr[i, 1] * arr[i, 1] <= 1)
                                s += 10;
                            else if (arr[i, 0] * arr[i, 0] + arr[i, 1] * arr[i, 1] <= 4)
                                s += 5;
                        }
                    }
                    break;
                case '2':
                    {
                        //Генерируем случайным образом свиг центра
                        Random x = new Random();
                        int a = x.Next(-5, 5);
                        int b = x.Next(-5, 5);

                        Console.WriteLine("a = {0}\nb = {1}", a, b);
                        for (int i = 0; i < n; i++)
                        {
                            if (Math.Pow((arr[i, 0] - a),2) + Math.Pow((arr[i, 1] - b),2)<= 1)
                                s += 10;
                            else if (Math.Pow((arr[i, 0] - a), 2) + Math.Pow((arr[i, 1] - b), 2) <= 4)
                                s += 5;
                        }

                    }
                    break;
                case '3':
                    {
                        //генерация количества незасчитанных выстрелов
                        Random _r = new Random();
                        int p = 0; //запоминаем сколько выстрелов не защитано

                        for (int i = 0; i < n; i++)
                        {
                            int k = _r.Next(0, 3);
                            if (k == 1)
                            {
                                p++;
                                continue;
                            }
                            else if (arr[i, 0] * arr[i, 0] + arr[i, 1] * arr[i, 1] <= 1)
                                s += 10;
                            else if (arr[i, 0] * arr[i, 0] + arr[i, 1] * arr[i, 1] <= 4)
                                s += 5;
                        }
                        Console.WriteLine("Количство незасчитанных высрелов: {0} ", p);

                    }
                    break;
            }

            Console.WriteLine("Вы набрали {0} баллов", s);






        }
    }
}
