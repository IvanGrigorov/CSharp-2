/* Write a program that converts a string to a sequence of C# Unicode character literals.
   Use format strings.*/



using System;


namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            string unicode = string.Empty;
            for (int i = 0; i < userString.Length; i++)
            {
                unicode += String.Format("\\u{0}", ((int)userString[i]).ToString("X4"));
            }
            Console.WriteLine(unicode);
        }
    }
}
