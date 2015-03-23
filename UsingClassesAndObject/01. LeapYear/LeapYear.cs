/* 
    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
*/



using System;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year. ");
            Console.Write("Year = ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the year leap - {0}", DateTime.IsLeapYear(year) ? "Yes" : "No");
        }
    }
}
