/* Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
   Display them in the standard date format for Canada.*/


using System;
using System.Globalization;
using System.Threading;


namespace _19.DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            String format = "dd.MM.yyyy";
            for (int i = 0; i < userString.Length; i++)
            {
                if (Char.IsDigit(userString[i]))
                {
                    DateTime dateTime;
                    if (DateTime.TryParseExact(userString.Substring(i, 10), format,
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                        Console.WriteLine(dateTime);
                        i = i + 10;
                    }
                }
            }
        }
    }
}
