/*Write a program that compares two char arrays 
  lexicographically (letter by letter).*/



using System;


namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the two arrays. ");
            int length = int.Parse(Console.ReadLine());
            char[] arr1 = new char[length];
            char[] arr2 = new char[length];
            Console.WriteLine("Enter the elements of the first array. ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = char.Parse(Console.ReadLine());
                while (!(Char.IsLetter(arr1[i])))
                {
                    Console.WriteLine("The input must be a letter. Try again. ");
                    Console.WriteLine("arr1[{0}] = ", i);
                    arr1[i] = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of the second array. ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr2[{0}] = ", i);
                arr2[i] = char.Parse(Console.ReadLine());
                while (!(Char.IsLetter(arr2[i])))
                {
                    Console.WriteLine("The input must be a letter. Try again. ");
                    Console.WriteLine("arr2[{0}] = ", i);
                    arr2[i] = char.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("The element arr1[{0}] = {1} is after the element arr2[{2}] = {3}", i, arr1[i], i, arr2[i]);
                }
                else if (arr1[i] == arr2[i])
                {
                    Console.WriteLine("The element arr1[{0}] = {1} and the element arr2[{2}] = {3} are the same", i, arr1[i], i, arr2[i]);
                }
                else
                {
                    Console.WriteLine("The element arr2[{0}] = {1} is after the element arr1[{2}] = {3}", i, arr2[i], i, arr1[i]);
                }
            }
        }
    }
}
