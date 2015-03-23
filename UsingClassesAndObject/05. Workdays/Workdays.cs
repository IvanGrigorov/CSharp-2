/* 
    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/


using System;
using System.Collections.Generic;

namespace _05.Workdays
{
    class Workdays
    {
        static List<DateTime> holidays = new List<DateTime>()
            { new DateTime(2015, 3, 1),new DateTime(2015, 3, 3),new DateTime(2015, 4, 2),
              new DateTime(2015, 4, 10), new DateTime(2015, 5, 2),new DateTime(2015, 5, 12),
              new DateTime(2015, 5, 16),new DateTime(2015, 6, 13),new DateTime(2015, 6, 15)
            };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start date. ");
            Console.Write("Day = ");
            int startDay = int.Parse(Console.ReadLine());
            Console.Write("Month = ");
            int startMonth = int.Parse(Console.ReadLine());
            Console.Write("Year = ");
            int startYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end date. ");
            Console.Write("Day = ");
            int endDay = int.Parse(Console.ReadLine());
            Console.Write("Month = ");
            int endMonth = int.Parse(Console.ReadLine());
            Console.Write("Year = ");
            int endYear = int.Parse(Console.ReadLine());
            Console.WriteLine("There are {0} Workdays in the interval.", WorkdaysCount(new DateTime(startYear, startMonth, startDay), new DateTime(endYear, endMonth, endDay)));

        }
        static int WorkdaysCount(DateTime start, DateTime end)
        {
            int workdayCounter = 0;
            DateTime now = start;
            while (now <= end)
            {
                if (!holidays.Contains(now) && (int)now.DayOfWeek != 0 && (int)now.DayOfWeek != 6)
                {
                    ++workdayCounter;
                }
                now = now.AddDays(1);
            }
            return workdayCounter;
        }
    }
}
