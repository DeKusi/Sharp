using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3_4
{
    class Party
    {
        private int amounth;
        private int bet;

        public void Change(int amounth, int bet)
        {
            this.amounth = amounth;
            this.bet = bet;
        }

        //метод генерации
        private int Generation()
        {
            Random r = new Random();
            int gen = r.Next() % 2;
            return gen;
        }

        //
        public bool Result()
        {
            if (Generation() == bet)
            {
                //bal += amounth;
                Console.WriteLine("Поздравляем! Вы выиграли!");
                return true;
            }
            else
            {
                //bal -= amounth;"
                Console.WriteLine("Сожалеем, ставка не сыграла ");
                return false;
            }
        }
        




     }
}
