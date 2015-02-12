/* Write a program that creates an array containing all letters from the alphabet (A-Z).
   Read a word from the console and print the index of each of its letters in the array.*/



using System;


namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word you are looking for. ");
            String word = Console.ReadLine();          
            char[] arr1 = new char[26];
            char letter = 'A';
            int tmpIndeks = -1; 
            for (int i = 0; i < 26; i++)
            {
                arr1[i] = letter;
                letter++;
            }
            int length = word.Length;
            for (int i = 0; i < 26; i++)
            {
                if (arr1[i] == word[0])
                {
                    tmpIndeks = i;
                }
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} = {1}, ", word[i], tmpIndeks);
                tmpIndeks++;
            }
        }
    }
}
