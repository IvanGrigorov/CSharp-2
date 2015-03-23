/* You are given a sequence of positive integer values written into a string, separated by spaces.
   Write a function that reads these values from given string and calculates their sum.*/



using System;

namespace _06.SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sequence of numbers separated by a space. ");
            Console.Write("sequence = ");
            String sequence = Console.ReadLine();
            int sum = 0;
            String[] numbers = sequence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            Console.WriteLine("The sum is {0} ", sum);
        }
    }
}
