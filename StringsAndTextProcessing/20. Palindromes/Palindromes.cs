/* Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/


using System;
using System.Text;


namespace _20.Palindromes

{
    class Palindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            String[] words = userString.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                counter = 0;
                for (int j = 0,l = words[i].Length - 1; j < (words[i].Length / 2); j++, l--)
                {
                    if (words[i][j] == words[i][l])
                    {
                        counter++;
                    }
                }
                if (counter == (words[i].Length / 2))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
