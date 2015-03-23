/* Write a method that reverses the digits of given decimal number.*/



using System;


namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to reverse. ");
            Console.Write("number = ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("The reversed number is {0}. ", ReversingNumber(number));

        }
        static String ReversingNumber(double number)
        {
            char[] reversedNumber = number.ToString().ToCharArray();
            Array.Reverse(reversedNumber);
            return new string(reversedNumber);
        }
    }
}
