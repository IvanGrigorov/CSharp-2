/* Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/


using System;

namespace _08.BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("N = ");
            short N = short.Parse(Console.ReadLine());
            int[] binaryRepresentation = new int[16];
            int length = 15;
            while (N > 0)
            {
                binaryRepresentation[length]=(N % 2);
                N = (short)(N / 2);
                length--;
            }
            foreach (int x in binaryRepresentation)
            {
                Console.Write(x);
            }
        }
    }
}
