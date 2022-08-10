using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage1
{
    class EmployeepresentAbsent
    {
        public void PresentAbsent()
        {
            Random Empcheck = new Random();
            int Check = Empcheck.Next(0,2);
            int EmployeePresent = 1;

            if(Check == EmployeePresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
