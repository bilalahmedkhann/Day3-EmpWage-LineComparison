
namespace LineComparison_Day3
{
    public class LengthOfLine
    {
        public static double LengthCalculation(int x1, int y1, int x2,int y2 )
        {
            double lengthOfLine = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
            return lengthOfLine;
        }
    }
}
