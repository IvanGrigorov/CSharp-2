/* Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
   and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/


using System;
using System.Threading;
using System.Globalization;


namespace _17.DateInBulgaria
{
    class DateInBulgaria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date with format dd.mm.yyyy hour:minute:second . ");
            Console.Write("first date = ");
            String firstDate = Console.ReadLine();
            DateTime date = Convert.ToDateTime(firstDate);
            date = date.AddHours(6);
            date = date.AddMinutes(30);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            CultureInfo culture = new CultureInfo("bg-BG");
            Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss} , Day of Week {1} ",date, DateTimeFormatInfo.CurrentInfo.GetDayName(date.DayOfWeek));
        }
    }
}
