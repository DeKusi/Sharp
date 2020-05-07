using System;
using System.IO;

namespace Practice_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Добро пожаловать в казино. Представтесь пожалуйста");
                string name = Console.ReadLine();
                Console.WriteLine("Введите начальный баланс");
                e: int bal = int.Parse(Console.ReadLine());
                if (bal <= 0)
                {
                    Console.WriteLine("Введён некорректный баланс, попробуйте ввести другое число");
                    goto e;
                }
                Player player = new Player(bal, name);
                player.Play();
                //запись данных в файл по завершении игры
                string text = "Игрок " + name + " :\nБаланс на момент окончания игры " + player.Get_Bal() + "р";
                StreamWriter sw = new StreamWriter("GameOver.txt", true);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}",
                e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An DivideByZero exception was thrown: {0}",
                e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }

        }
    }
}
