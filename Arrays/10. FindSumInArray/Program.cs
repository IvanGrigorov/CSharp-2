/* Write a program that finds in given array of integers a sequence of given sum S (if present).*/



using System;


namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter what kind of sum you are searching for. ");
            int S = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            int sum = 0;
            int startIndex = -1;
            int finalIndeks = -1;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length && sum != S; i++)
            {
                sum = 0;
                for (int j = i; j < length; j++)
                {
                    sum += arr1[j];
                    if (sum == S)
                    {
                        startIndex = i;
                        finalIndeks = j;
                        break;
                    }
                }
            }
            Console.WriteLine();
            if (sum == S)
            {
                for (int i = startIndex; i <= finalIndeks; i++)
                {
                    Console.Write("{0}, ", arr1[i]);
                }
            }
            else
            {
                Console.WriteLine("There is no such sequence in the array. ");
            }
        }
    }
}
