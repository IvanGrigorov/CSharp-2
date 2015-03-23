/* Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/



using System;


namespace _04.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of the array. N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number K = ");
            int K = int.Parse(Console.ReadLine());
            int indeks = -1;
            int[] array = new int[N];
            
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int min = array[0];
            for (int i = K; i >= min; i--)
            {
                if (Array.BinarySearch(array, i) > -1)
                {
                    indeks = Array.BinarySearch(array, i);
                    break;
                }
            }
            Console.WriteLine("The suitable number is at indeks {0} and it is {1}.", indeks, array[indeks]);
        }
    }
}
