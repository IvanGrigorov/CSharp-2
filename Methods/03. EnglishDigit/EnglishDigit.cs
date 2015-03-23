/* Write a method that returns the last digit of given integer as an English word.*/


using System;

namespace _03.EnglishDigit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number. ");
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(EnglishDigitPrinter(number));
        }
        static String EnglishDigitPrinter(int number)
        {
            int digit = number%10;
            switch (digit)
            {
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    return "Zero";
            }
        }
    }
}
