/* Write a program that reverses the words in given sentence.*/


using System;
using System.Text;


namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            String[] words = userString.Split(new[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            char sign = userString[userString.Length - 1];
            StringBuilder reversedString = new StringBuilder();
            for (int i = words.Length - 1; i > 0; i--)
            {
                reversedString.Append(words[i]);
                reversedString.Append(" ");
            }
            reversedString.Append(words[0]);
            reversedString.Append(sign);
            Console.WriteLine(reversedString.ToString());
        }
    }
}
