/* Write a program that reads from the console a string of maximum 20 characters. 
   If the length of the string is less than 20, the rest of the characters should be filled with *.
   Print the result string into the console.*/



using System;
using System.Text;


namespace _06.StringLenght
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String with maximum 20 characters. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            StringBuilder newString = new StringBuilder(userString);
            if (userString.Length < 20)
            {
                for (int i = 0; i < 20 - userString.Length; i++)
                {
                    newString.Append("*");
                }
            }
            Console.WriteLine(newString.ToString());
        }
    }
}
