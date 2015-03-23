/* Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/


using System;

namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your words separated by a space. ");
            Console.Write("Words = ");
            String userString = Console.ReadLine();
            String[] words = userString.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            foreach (String x in words)
            {
                Console.Write("{0}, ", x);
            }
        }
    }
}
