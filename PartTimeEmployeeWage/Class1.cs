using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTimeEmployeeWage
{
    class ParttimeFullTime
    {
        public int EmployeePartTimeFullTime()
        {
            int EmployeeWagePerHour = 20;
            int DailyWage = 0;
            int EmpHrs = 0;

            Random EmpCheck = new Random();
            int Check = EmpCheck.Next(0, 3);
            int EmployeeFullTime = 1;
            int EmployeePartTime = 2;

            if(Check == EmployeeFullTime)
            {
                Console.WriteLine("employee is present for full time.");
                EmpHrs = 8;

            }
            else if (Check == EmployeePartTime)
            {
                Console.WriteLine("employee is present for part time.");
                EmpHrs = 4;

            }
            else
            {
                Console.WriteLine("employee is absent");
                EmpHrs = 0;
            }
            DailyWage = EmployeeWagePerHour * EmpHrs;
            return DailyWage;
        }
    }
}
