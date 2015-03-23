/* Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).*/



using System;


namespace _05.LargerThenNeighbours
{
    class LargerThenNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ënter the lenght of the array. ");
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            Console.WriteLine("Fill the array. ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(" array[{0}] =", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the indeks of a number you want to check. ");
            int indeks = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this number {0} bigger then its neighbours: {1}. ", array[indeks], NeighboursCheck(array, indeks, N));
        }
        public static bool NeighboursCheck(int[] array, int indeks, int lenght)
        {
            if ((indeks - 1 < 0) || (indeks + 1 >= lenght))
            {
                throw new ArgumentException(" There are not two neghbours in the array. ");
            }
            else
            {
                if ((array[indeks] > array[indeks - 1]) && (array[indeks] > array[indeks + 1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
