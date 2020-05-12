using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Task
{
    public class Admin : Person
    {
        string lab { get; set; }

        public Admin(string surname, DateTime date, string lab) : base(surname, date)
        {
            this.lab = lab;
        }

        public override void Get_Info()
        {
            base.Get_Info();
            Console.WriteLine("Лаборатория: {0}", this.lab);
        }
    }
}
