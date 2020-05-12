using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Task 
{
    public class Teacher : Person, ITeacher
    {
        string faculty { get; set; }
        string position { get; set; }
        int s_work { get; set; }  //start work
        int experience;
        double salary;
        private int average_salary = 40000;

        public Teacher(string surname, DateTime date, string faculty, string position, int s_work) : base(surname, date)
        {
            this.faculty = faculty;
            this.position = position;
            this.s_work = s_work;
            this.experience = this.Calculate_Experience();
            this.salary = this.Calculate_Salary();
        }

        public override void Get_Info()
        {
            base.Get_Info();
            Console.WriteLine("Факультет: {0}", this.faculty);
            Console.WriteLine("Должность: {0}", this.position);
            Console.WriteLine("Стаж работы: {0}", this.experience);
            Console.WriteLine("Зарплата: {0}", this.salary);
        }

        //стаж работы в этой фирме
        public int Calculate_Experience()
        {
            return DateTime.Now.Year - this.s_work;
        }

        //рассчёт зп
        public double Calculate_Salary()
        {
            if (this.experience > 6)
            {
                return average_salary * 1.1;
            }
            else if (this.experience < 2)
            {
                return average_salary * 0.9;
            }
            else return average_salary;
        }


    }
}
