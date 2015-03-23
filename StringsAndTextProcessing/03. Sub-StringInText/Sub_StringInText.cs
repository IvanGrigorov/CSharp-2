/* Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).*/



using System;


namespace _03.Sub_StringInText
{
    class Sub_StringInText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            int indeks = 0;
            int counter = 0;
            while (true)
            {
                int found = userString.IndexOf("in", indeks);
                if (found < 0)
                {
                    break;
                }
                else
                {
                    counter++;
                    indeks = found + 1;
                }
            }
            Console.WriteLine("Such indeks is found {0} times. ", counter);
        }
    }
}
