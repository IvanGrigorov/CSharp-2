/* Write a program that reads a string from the console and prints all different letters in the string 
   along with information how many times each letter is found.*/


using System;
using System.Collections.Generic;


namespace _21.LettersCount
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            List<char> used = new List<char>();
            int[] amount = new int[userString.Length];
            //char[] used = new char[userString.Length];
            for (int i = 0; i < userString.Length; i++)
            {
                if (used.IndexOf(userString[i])<0)
                {
                    used.Add(userString[i]);
                    amount[i]++;
                }
                else
                {
                    amount[used.IndexOf(userString[i])]++;
                }
            }
            for (int i = 0; i < used.Count; i++)
            {
                Console.WriteLine("The char {0} is found {1} times.", used[i], amount[i]);
            }
        }
    }
}
