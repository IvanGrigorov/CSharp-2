/* Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/



using System;

namespace _11.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number you want to search for. ");
            int number = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr1);
            Console.WriteLine(BinarySearch(arr1, number, 0, length));
        }
        public static int BinarySearch(int[] array, int number, int start, int end)
        {
            int mitt = (start + end) / 2;
            if (array[mitt] == number)
            {
                return (mitt);
            }
            else if (array[mitt] < number)
            {
                return (BinarySearch(array, number, mitt+1, end));
            }
            else
            {
                return (BinarySearch(array, number, 0, mitt-1));
            }
        }
    }
}
