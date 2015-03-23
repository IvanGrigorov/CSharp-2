/* Write a program for extracting all email addresses from given text.
   All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/


using System;
using System.Text;
using System.Collections.Generic;

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            String[] Emails = userString.Split(new[] {"<identifier>@<host>", "<domain>"}, StringSplitOptions.RemoveEmptyEntries);
            List<String> extractEmails = new List<String>();
            for (int i = 0; i < Emails.Length; i++)
            {
                if (i % 2 != 0)
                {
                    extractEmails.Add(Emails[i]);
                }
            }
            foreach (string x in extractEmails)
            {
                Console.WriteLine(x);
            }
        }
    }
}
