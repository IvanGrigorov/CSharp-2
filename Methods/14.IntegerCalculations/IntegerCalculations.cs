/* Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
   Use variable number of arguments.*/



using System;


namespace _14.IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ënter the lenght of the set. ");
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            Console.WriteLine("Fill the set. ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(" array[{0}] =", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int minimum = 0;
            Console.WriteLine("The minimum of the set is {0}. ", Minimum(minimum, array));
            Console.WriteLine("The maximum of the set is {0}. ", Maximum(array));
            Console.WriteLine("The average of the set is {0}. ", Average(array));
            int sum = 0;
            Console.WriteLine("The sum of the set is {0}. ", Sum(sum, array));
            long product = 1;
            Console.WriteLine("The product of the set is {0}. ", Product(product, array));
        }
        static int Minimum(int result, int[] array)
        {
            result = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < result)
                {
                    result = array[i];
                }
            }
            return result;
        }
        static int Maximum(int[] array)
        {
            int result = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }
            }
            return result;
        }
        static double Average(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                    sum += array[i];
            }
            return sum/array.Length;
        }
        static int Sum(int sum, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static long Product(long product, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
    }
}
