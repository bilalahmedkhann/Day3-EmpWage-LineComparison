using System;

namespace EmpWageLoop
{
    internal class Program
    {
        public const int EMP_RATE_PER_HOUR = 20;
        public const int num_of_working_days = 20;

        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            Random rand = new Random();


            for (int day = 0; day < num_of_working_days; day++)
            {
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage = totalEmpWage + empWage;
            }
            Console.WriteLine("Total salary of employee: " + totalEmpWage);
        }
    }
}
