/* Write a program that replaces in a HTML document given as string all the tags    
   <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/


using System;

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            userString = userString.Replace("<a href=\"", "[URL=")
                                   .Replace("\">", "]")
                                   .Replace("</a>", "[/URL]");
            Console.WriteLine(userString);
        }
    }
}
