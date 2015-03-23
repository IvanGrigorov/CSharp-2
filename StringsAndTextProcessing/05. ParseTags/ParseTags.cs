/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.*/



using System;

namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            string[] split = {"<upcase>", "</upcase>" };
            String[] newString = userString.Split(split, StringSplitOptions.None);
            for (int i = 0; i < newString.Length; i++)
            {
                if (i % 2 != 0)
                {
                   newString[i] = newString[i].ToUpper();
                }
            }
            string result = String.Join("", newString);
            Console.WriteLine(result);
        }
    }
}
