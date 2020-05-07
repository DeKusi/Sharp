using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3_4
{
    class Player
    {
        private int k = 0;
        private int bal;
        private string name;
        private Party part = new Party();//создаём объект разыгрываемой игроком партии

        public Player(int bal, string name)
        {
            this.bal = bal;
            this.name = name;
        }

        //метод, возвращающий текущий баланс
        public int Get_Bal()
        {
            return this.bal;
        }

        //функция, предоставляющая выбор игроку после ставки
        bool Choise()
        {
            if (this.bal != 0 && this.k >= 3)
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
                            return false;
                        }
                }
            }
            else if (this.bal != 0 && this.k < 3)
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

        public void Play()
        {
            int amounth;
            int bet;
            Console.WriteLine("Начнём игру {0}", this.name);
            while (this.Choise())
            {
                
                Console.WriteLine("Делайте вашу ставку");
                this.k++;
                Console.WriteLine("Ввведите размер ставки: ");
                ex: amounth = int.Parse(Console.ReadLine());
                if (amounth > this.bal)
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
                //вводим данные новой партии
                part.Change(amounth, bet);



                //печатаем результат и изменяем баланс
               if (part.Result())
               {
                    this.bal += amounth;
                    Console.WriteLine("Ваш баланс увеличился на {0} и составляет {1}", amounth, this.bal);
                    
               }
                else
                {
                    this.bal -= amounth;
                    Console.WriteLine("Ваш баланс уменьшился на {0} и составляет {1}", amounth, this.bal);
                }

                
            }
        }




        //к игроку принадлежат параметры: баланс(вводится через конструктор), количество партий, ?размер ставки, ?выбор игрока(чёт нечет, меняется при каждой игре)
        //создаётся 
        //метод, возвращающий текущий баланс

        //метод, изменяющий баланс в зависимости от разыганной партии
        // k - количетво сыгранных партий
        //метод, увеличивающий k (как увеличивать)
        //метод Play, запускающий игру(один раз, а не одну патию)
        //метод end, заканчивающий игру этого игрока
        //метод, выбор игрока продолжать игру или закончить

    }
}
