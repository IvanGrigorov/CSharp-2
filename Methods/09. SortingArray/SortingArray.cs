/* Write a method that return the maximal element in a portion of array of integers starting at given index.
   Using it write another method that sorts an array in ascending / descending order.*/



using System;


namespace _09.SortingArray
{
    class SortingArray
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
            Console.WriteLine("The maximum in the array is {0}. ", MaxElement(array, 0)[0]);
            Console.WriteLine("The sorted array is: ");
            SortArray(array);
            foreach (int x in array)
            {
                Console.WriteLine("{0}, ", x);
            }

        }
        static int[] MaxElement(int[] array, int startIndeks)
        {
            int max = int.MinValue;
            int indeks = -1;
            int[] result = new int[2];
            for (int i = startIndeks; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indeks = i;
                }
            }
            result[0] = max;
            result[1] = indeks;
            return result;
        }
        static int[] SortArray(int[] array)
        {
            int indeks = 0;
            while (indeks < array.Length)
            {
                int tmp = MaxElement(array, indeks)[0];
                array[MaxElement(array, indeks)[1]] = array[indeks];
                array[indeks] = tmp;
                indeks++;
            }
            return array;
        }
    }
}
