using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Task
{
    public class Manager:Person
    {
        string  faculty { get; set; }
        string position { get; set; }

    public Manager (string surname, DateTime date, string faculty, string position) : base(surname, date)
        {
            this.position = position;
            this.faculty = faculty;
        }

        public override void Get_Info()
        {
            base.Get_Info();
            Console.WriteLine("Факультет: {0}", this.faculty);
            Console.WriteLine("Должность: {0}", this.position);
        }
    }
}
