/* Write a method GetMax() with two parameters that returns the larger of two integers.
   Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/


using System;


namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three numbers. ");
            Console.Write("num1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2 = ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("num3 = ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("max = {0} ", GetMax(GetMax(num1, num2), num3));
        }
        static int GetMax(int num1, int num2)
        {
            int max = Math.Max(num1, num2);
            return max;
        }
    }
}
