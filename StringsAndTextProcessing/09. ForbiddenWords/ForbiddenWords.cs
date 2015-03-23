/* We are given a string containing a list of forbidden words and a text containing some of these words.
   Write a program that replaces the forbidden words with asterisks.*/



using System;
using System.Text;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            String[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                userString = userString.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
            Console.WriteLine(userString);
        }
    }
}
