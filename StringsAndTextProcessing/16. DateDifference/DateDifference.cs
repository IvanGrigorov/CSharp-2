/* Write a program that reads two dates in the format: 
   day.month.year and calculates the number of days between them.*/


using System;
using System.Linq;


namespace _16.DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first date with format dd.mm.yyyy . ");
            Console.Write("first year = ");
            String firstYear = Console.ReadLine();
            Console.WriteLine("Enter your second date with format dd.mm.yyyy . ");
            Console.Write("second year = ");
            String secondYear = Console.ReadLine();
            DateTime fYear = Convert.ToDateTime(firstYear);
            DateTime sYear = Convert.ToDateTime(secondYear);
            TimeSpan ts = fYear - sYear;
            Console.WriteLine("Diference: {0} days.", Math.Abs(ts.Days));
        }
    }
}
