/* Write a program that reads an integer number and calculates and prints its square root.
   If the number is invalid or negative, print Invalid number.
   In all cases finally print Good bye.
   Use try-catch-finally block.*/


using System;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("The square is {0} .", Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not an integer. ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is bigger then the integer. ");
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye. ");
            }
        }
        public static double Sqrt(int number) {
            if (number < 0) {
                throw new ArgumentException 
                ("The argument is invalid. ");
            }
            return Math.Sqrt(number);
        }
    }
}
