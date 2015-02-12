/* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
   Use the Selection sort algorithm: 
   Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/


using System;

namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. ");
            int length = int.Parse(Console.ReadLine());
            int indeks = 0;
            int[] arr1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            while (indeks < length - 1)
            {
                int min = arr1[indeks];
                for (int i = indeks; i < length; i++)
                {
                    if (arr1[i] < min)
                    {
                        int tmp = arr1[i];
                        arr1[i] = arr1[indeks];
                        arr1[indeks] = tmp;
                    }
                }
                indeks++;
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0}, ", arr1[i]);
            }
        }
    }
}
