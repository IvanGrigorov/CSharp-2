/* You are given an array of strings. 
   Write a method that sorts the array by the length of its elements (the number of characters composing them).*/



using System;


namespace _05.SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. N= ");
            int N = int.Parse(Console.ReadLine());   
            String[] array = new String[N];   
            for (int i = 0; i < N; i++)
            {
                    Console.WriteLine("Enter the array[{0}] = ", i);
                    array[i] = Console.ReadLine();
            }
            Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
            Console.WriteLine(string.Join(",", array));
        }
    }
}
