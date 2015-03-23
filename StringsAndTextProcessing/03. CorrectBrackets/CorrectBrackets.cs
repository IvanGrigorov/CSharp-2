/* Write a program to check if in a given expression the brackets are put correctly.*/


using System;


namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == '(')
                {
                    counter++;
                }
                if (userString[i] == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    Console.WriteLine("Incorrect");
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Correct");
            }
            else if (counter > 0)
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
