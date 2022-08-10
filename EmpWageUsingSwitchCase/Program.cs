using System;

namespace EmpWageLoop
//Calculate salary wage of employee using switch case: 



{
    internal class Program
    {
        public const int EMP_RATE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            int empHrs = 8, empWage = 20, totalEmpWage = 0;
            Random rand = new Random();


            {
               int empCheck = rand.Next(0, 3);
                Console.WriteLine(empCheck);

                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;                                 // PART TIME
                        break;
                    case 2:
                        empHrs = 8;                                 // FULL TIME
                        break;

                    default:
                        empHrs = 0;                                 // ABSENT
                        break;

                }
                totalEmpWage = empHrs * EMP_RATE_PER_HOUR;
            }
            Console.WriteLine("Total daily salary of employee: " + totalEmpWage);
        }
    }
}
