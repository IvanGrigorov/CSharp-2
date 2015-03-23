/* Write a program to convert decimal numbers to their binary representation.*/



using System;
using System.Collections.Generic;

namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            List<int> binaryRepresentation = new List<int>();
            while (N > 0)
            {
                binaryRepresentation.Add(N % 2);
                N = N / 2;
            }
            binaryRepresentation.Reverse();
            Console.WriteLine(String.Join("", binaryRepresentation.ToArray()));
        }
    }
}
