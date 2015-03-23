/* Write a program that reads a string from the console and replaces 
   all series of consecutive identical letters with a single one.*/


using System;
using System.Text;

namespace _23.SeriesOfLetter
{
    class SeriesOfLetter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            StringBuilder result = new StringBuilder(); 
            result.Append(userString[0]);
            for (int i = 1; i < userString.Length; i++)
            {
                if (userString[i] != userString[i - 1])
                {
                    result.Append(userString[i]);
                }
            }    
            Console.WriteLine(result.ToString());
        }
    }
}
