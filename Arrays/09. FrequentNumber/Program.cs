/* Write a program that finds the most frequent number in an array.*/



using System;


namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array. ");
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            int indeks = 0;
            int frequentNumber = 0;
            int counter = 0;
            int timesInArray = 0;
            int mostFrequentNumber = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            while (indeks < length)
            {
                counter = 0;
                frequentNumber = arr1[indeks];
                for (int i = indeks; i < length; i++)
                {
                    if (arr1[i] == frequentNumber)
                    {
                        counter++;
                    }
                }
                if (counter > timesInArray)
                {
                    mostFrequentNumber = frequentNumber;
                    timesInArray = counter;
                }
                indeks++;
            }
            Console.WriteLine();
            Console.WriteLine("The most frequent number is {0} and it can be found {1} times in the array. ", mostFrequentNumber, timesInArray);
        }
    }
}
