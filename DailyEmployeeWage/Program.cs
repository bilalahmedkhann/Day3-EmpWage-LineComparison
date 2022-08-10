// Check employee daily wage if present or absent using RANDOM:


using System;

namespace UC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EmployeeWagePerHour = 20;
            int FullTimeWorkingHours = 8;
            //int HalfTimeWorkingHours = 4;

            //Console.WriteLine("Hello World!");
            Random rand = new Random();
            int num = rand.Next(0, 2);
            //Console.WriteLine(num);
            if (num == 1)
            {
                Console.WriteLine("Employee is present and his daily wage is "+(EmployeeWagePerHour*FullTimeWorkingHours)+".");

            }
            else
            {
                Console.WriteLine("Employee is absent and his daily wage is 0.");
            }
        }
    }
}
