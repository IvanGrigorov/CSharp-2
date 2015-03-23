/* Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
   Format the output aligned right in 15 symbols.*/



using System;

namespace _11.FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("number = ");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{0, 15:D}, {0, 15:X}, {0, 15:P2}, {0, 15:E}", userNumber);
        }
    }
}
