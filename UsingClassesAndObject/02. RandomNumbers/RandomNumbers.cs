/* Write a program that generates and prints to the console 10 random values in the range [100, 200].*/



using System;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("random number = {0} ", generator.Next(100, 201));
            }

        }
    }
}
