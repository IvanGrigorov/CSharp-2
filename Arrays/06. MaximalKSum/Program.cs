/* Write a program that reads two integer numbers N and K and an array of N elements from the console.
   Find in the array those K elements that have maximal sum.*/


using System;


namespace _06.MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many numbers you want to add. ");
            int K = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr1);
            Console.WriteLine();
            for (int i = N - K; i < N; i++)
            {
                Console.Write("{0}, ", arr1[i]);
            }
        }
    }
}
