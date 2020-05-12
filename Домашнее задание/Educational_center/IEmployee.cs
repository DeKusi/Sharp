using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Task
{
    interface ITeacher
    {
        //определение стажа
        int Calculate_Experience();
        //определение зп
        double Calculate_Salary();
    }
}
