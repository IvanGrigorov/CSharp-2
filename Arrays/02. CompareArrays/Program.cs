/* Write a program that reads two integer arrays from the console 
   and compares them element by element.*/


using System;



namespace _02.CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the two arrays. ");
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            int[] arr2 = new int[length];
            Console.WriteLine("Enter the elements of the first array. ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the elements of the second array. ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr2[{0}] = ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("The element arr1[{0}] = {1} is bigger then element arr2[{2}] = {3}", i, arr1[i], i, arr2[i]);
                }
                else if (arr1[i] == arr2[i]) 
                {
                    Console.WriteLine("The element arr1[{0}] = {1} and the element arr2[{2}] = {3} are even", i, arr1[i], i, arr2[i]);
                }
                else
                {
                    Console.WriteLine("The element arr2[{0}] = {1} is bigger then element arr1[{2}] = {3}", i, arr2[i], i, arr1[i]);
                }
            }
        }
    }
}
