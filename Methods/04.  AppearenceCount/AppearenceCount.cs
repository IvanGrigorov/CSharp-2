/* Write a method that counts how many times given number appears in given array.
   Write a test program to check if the method is workings correctly.*/




using System;


namespace _04.AppearenceCount
{
    class AppearenceCount
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
            Console.WriteLine("Enter the number you want to check. ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} is found {1} times in the array. ", number, AppearenceCounter(array, number));
        }
        static int AppearenceCounter(int[] array, int number)
        {
            int counter = 0;
            foreach (int x in array)
            {
                if (x == number)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
