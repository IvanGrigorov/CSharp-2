/* Write a program that reads a string, reverses it and prints the result at the console.*/ 



using System;
using System.Text;


namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            StringBuilder reverseString = new StringBuilder();
            for (int i = userString.Length -1; i >= 0; i--)
            {
                reverseString.Append(userString[i]);
            }
            Console.WriteLine("The reversed string is {0}. ", reverseString.ToString());
        }
    }
}
