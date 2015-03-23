/* Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
   Each of the numbers that will be added could have up to 10 000 digits.*/



using System;


namespace _08.NumberAsArray
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the first digit.");
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            Console.WriteLine("Fill the array with digits of the number in reversed order. ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(" arr1[i] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the lenght of the second number. ");
            Console.Write("N2 = ");
            int N2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[N2];
            Console.WriteLine("Fill the array with digits of the number in reversed order. ");
            for (int i = 0; i < N2; i++)
            {
                Console.Write(" arr2[i] = ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum of the two numbers is {0} ", SumOfNumbers(arr1, arr2));
        }
        static int SumOfNumbers(int[] arr1, int[] arr2)
        {
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            String number1 = String.Join("", arr1);
            String number2 = String.Join("", arr2);
            return int.Parse(number1) + int.Parse(number2);
        }
    }
}
