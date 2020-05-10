using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bal = 0; //Баланс игрока
            int amounth = 0; //Размер ставки
            int bet = 0; //Ставка
            int k = 0;//счётчик количества ставок (только после 3х человек может закончить игру)

            //функция для запуска игры

                void Start()
                {
                try
                {
                    Console.WriteLine("Для запуса игры вам требуется ввести баланс: ");
                    e: bal = int.Parse(Console.ReadLine());
                    if (bal <= 0)
                    {
                        Console.WriteLine("Введён некорректный баланс, попробуйте ввести другое число");
                        goto e;
                    }

                    while (Choise())
                    {
                        Make_bet();
                    }
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



            //функция одной ставки
            void Make_bet()
            {

                    Console.WriteLine("Делайте вашу ставку");
                    k += 1;
                    Console.WriteLine("Ввведите размер ставки: ");

                    ex: amounth = int.Parse(Console.ReadLine());
                    if (amounth > bal)
                    {
                        Console.WriteLine("Размер вашей ставки превышает ваш баланс, введите другое значение");
                        goto ex;
                    }

                    ex1: Console.WriteLine("Вы ставите на \n\t0. Чёт \t\n\t1. Нечёт");
                    bet = int.Parse(Console.ReadLine());
                    if ((bet != 1) && (bet != 0))
                    {
                        Console.WriteLine("Введён некорректный ответ, попробуйте ещё раз");
                        goto ex1;
                    }
                

                //объявление результатов
                if (Generation() == bet)
                {
                    bal += amounth;
                    Console.WriteLine("Поздравляем! Вы выиграли! \nВаш баланс увеличился на {0} и составляет {1}", amounth, bal);
                }
                else
                {
                    bal -= amounth;
                    Console.WriteLine("Сожалеем, ставка не сыграла \nВаш баланс уменьшился на {0} и составляет {1}", amounth, bal);
                }
            }

            //функция генерации
            int Generation()
            {
                Random r = new Random();
                int gen = r.Next()%2;
                return gen;
            }

            //функция, предоставляющая выбор игроку после ставки
            bool Choise()
            {
                if (bal != 0 && k >= 3)
                {
                    Console.WriteLine("Что вы хотите сделать?\t\n\t1. Продолжить играть\t\n\t2. Забрать выигрыш и выйти");
                    int l = int.Parse(Console.ReadLine());
                    switch (l)
                    {
                        case 1:
                            {
                                return true;
                            }
                        case 2:
                            {
                                Console.WriteLine("Ваш выигрыш составил {0}\nДо свидания", bal);
                                return false;
                            }
                    }
                }
                else if (bal != 0 && k < 3)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Извините, но вы не можете продолжать играть, ваш баланс 0");
                    return false;
                }

                return false;
            }

            Start();
        }
    }
}
