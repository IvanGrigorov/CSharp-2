/* A dictionary is stored as a sequence of text lines containing words and their explanations.
   Write a program that enters a word and translates it by using the dictionary.
   Sample dictionary:

   input	    output
   .NET	        platform for applications from Microsoft
   CLR	        managed execution environment for .NET
   namespace    hierarchical organization of classes*/


using System;

namespace _14.WordDictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Word. ");
            Console.Write("Word = ");
            String userString = Console.ReadLine();
            if (userString.CompareTo(".NET") == 0)
            {
                Console.WriteLine("platform for applications from Microsoft ");
            }
            if (userString.CompareTo("CLR") == 0)
            {
                Console.WriteLine("managed execution environment for .NET ");
            }
            if (userString.CompareTo("namespace") == 0)
            {
                Console.WriteLine("hierarchical organization of classes ");
            }
        }
    }
}
