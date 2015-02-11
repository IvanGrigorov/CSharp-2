/* Write a program that finds the maximal sequence of equal elements in an array.
   for example:  input: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1; result: 2, 2, 2 */


using System;


namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. ");
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            int sequence = 0;
            int counter = 1;
            int indeks = 0;
            Console.WriteLine("Enter the elements of the first array. ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length - 1; i++)
            {
                counter = 1;
                int currentindex = i;
                while (arr1[i] == arr1[i + 1])
                {
                    counter++;
                    i++;
                    if (i == length - 1) break;
                }
                if (sequence < counter)
                {
                    sequence = counter;
                    indeks = i - counter + 1;
                }
                i = currentindex;
            }
            Console.WriteLine();
            for (int i = 0; i < sequence; i++)
            {
                Console.WriteLine(arr1[indeks]);
                indeks++;
            }
        }
    }
}
