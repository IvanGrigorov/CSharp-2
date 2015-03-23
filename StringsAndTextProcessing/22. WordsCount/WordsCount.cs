/* Write a program that reads a string from the console 
   and lists all different words in the string along with information how many times each word is found.*/


using System;
using System.Collections.Generic;

namespace _22.WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            String[] words = userString.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<String> used = new List<String>();
            int[] amount = new int[userString.Length];
            //char[] used = new char[userString.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (used.IndexOf(words[i]) < 0)
                {
                    used.Add(words[i]);
                    amount[i]++;
                }
                else
                {
                    amount[used.IndexOf(words[i])]++;
                }
            }
            for (int i = 0; i < used.Count; i++)
            {
                Console.WriteLine("The char {0} is found {1} times.", used[i], amount[i]);
            }
        }
    }
}
