/* Write a program that finds the sequence of maximal sum in given array.
   Example: 2, 3, -6, -1, 2, -1, 6, 4, -8, 8; Result: 2, -1, 6, 4;*/


using System;

namespace _08.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. ");
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = arr1[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempStartIndex = 0;
            int maxSum = arr1[0];

            for (int i = 1; i < length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = arr1[i];
                    tempStartIndex = i;
                }
                else
                {
                    currentSum += arr1[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }

            Console.WriteLine("The best sum is: {0} ", maxSum);

            Console.WriteLine("The best sequence is:");

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
