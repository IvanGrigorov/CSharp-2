/* Write a program that extracts from a given text all sentences containing given word.*/



using System;
using System.Text;


namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            string[] split = { "." };
            String[] newString = userString.Split(split, StringSplitOptions.None);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < newString.Length; i++)
            {

                string[] check = newString[i].Split(' ');
                for (int j = 0; j < check.Length; j++)
                {
                    if (check[j].CompareTo("in") == 0)
                    {
                        result.Append(newString[i]);
                        result.Append(".");
                        Array.Clear(check, 0, check.Length);
                        break;
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
