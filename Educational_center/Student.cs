using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Task
{
    public class Student: Person
    {
        public string faculty { get; set; }
        public string group { get; set; }

        public Student(string surname, DateTime date, string group, string faculty) : base(surname, date)
        {
            this.group = group;
            this.faculty = faculty;
        }

        public override void Get_Info()
        {
            base.Get_Info();
            Console.WriteLine("Факультет: {0}", this.faculty);
            Console.WriteLine("Группа: {0}", this.group);
        }

    }

}
