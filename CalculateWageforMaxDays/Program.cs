
namespace CalculateWageforMaxDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            System.Console.WriteLine("Calculate Wage for 20 Days or 100 Hrs");
            const int Part_Time = 2;
            const int Full_Time = 1;
            const int empRatePerHr = 20;
            const int numOfWorkDay = 20;
            const int MaxWorkHr = 100;

            int empHr = 0;
            int totalwage = 0;
            int totalWorkDays = 0;
            int totalEmpHrs = 0;

            while (totalWorkDays < numOfWorkDay && totalEmpHrs <= MaxWorkHr)
            {
                totalWorkDays++;
                System.Random rand = new System.Random();
                
                int empCheck = rand.Next(0, 3);

                switch (empCheck)
                {
                    case Full_Time:
                        empHr = 8;
                        break;
                    case Part_Time:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;

                }
                totalEmpHrs += empHr;
            }
            totalwage = totalEmpHrs * empRatePerHr;
            System.Console.WriteLine("Day: " + totalWorkDays + "\nEmployee working Hrs: " + totalEmpHrs);
            System.Console.WriteLine("Total Salary is: " + totalwage);
        }
    }
}