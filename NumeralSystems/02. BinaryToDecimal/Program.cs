/* Write a program to convert binary numbers to their decimal representation.*/


using System;


namespace _02.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("N = ");
            String N = Console.ReadLine();
            int result = 0;
            int pow = N.Length - 1;
            for (int i = 0; i < N.Length; i++)
            {
                result += (int)(N[i] - '0')*(int)(Math.Pow(2,pow));
                pow--;
            }
            Console.WriteLine(result);
        }
    }
}
