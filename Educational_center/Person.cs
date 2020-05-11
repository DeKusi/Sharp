using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Task
{
    public abstract class Person
    {
        public DateTime date1;
        public string surname { get; set; }
        public int age { get; set; }
        DateTime NowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        public Person(string surname, DateTime date)
        {
            this.surname = surname;
            this.date1 = date;
            this.age = Count_Age();
        }

        int Count_Age()
        {
            System.TimeSpan diff1 = NowDate.Subtract(this.date1);
            int age = diff1.Days / 365;
            return age;
        }

        virtual public void Get_Info()
        {
            Console.WriteLine("Фамилия: {0}", this.surname);
            Console.WriteLine("Год рождения: {0}.{1}.{2}", this.date1.Day, this.date1.Month, this.date1.Year);
            Console.WriteLine("Возраст: {0}", this.age);
        }

    }
}
