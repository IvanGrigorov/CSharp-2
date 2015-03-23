/* Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
   Use the method from the previous exercise.*/



using System;


namespace _06.FirstLargerThenNeighbours
{
    class FirstLargerThenNeighbours
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
            Console.WriteLine("The first number, wich is bigger then its neighbours is at index {0}. ", FirstNumberChecker(array));
        }
        static int FirstNumberChecker(int[] array)
        {
            int indeks = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (NeighboursCheck(array, i, array.Length))
                {
                    indeks = i;
                    break;
                }
            }
            return indeks;
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
