/* Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0 */



using System;


namespace _13.SolveTasks
{
    class SolveTasks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program can sove three tasks for you. ");
            Console.WriteLine("To reverse the digits of a number press 1. ");
            Console.WriteLine("To calculate the average of a sequence of numbers press 2.");
            Console.WriteLine("To solve the equation a*x + b = 0 press 3. ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("You've chosen to reverse a digit. ");
                    Console.WriteLine("Enter your number. ");
                    Console.Write("number = ");
                    double number = double.Parse(Console.ReadLine());
                    Console.WriteLine("The reversed number is {0}. ", ReverseNumber(number));
                    break;
                case 2:
                    Console.WriteLine("You've chosen to calculate an average of a sequence. ");
                    Console.WriteLine("Enter the length of a sequece. ");
                    Console.Write("length = ");
                    int length = int.Parse(Console.ReadLine());
                    int[] sequence = new int[length];
                    Console.WriteLine("Enter all numbers in the sequence. ");
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write("sequence[{0}] = ", i);
                        sequence[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                    Console.WriteLine("The average of the sequence is {0}. ", FindAverage(sequence));
                        break;
                case 3:
                    Console.WriteLine("You've chosen to solve an eqaution. ");
                    Console.WriteLine("Enter the first parameter a . ");
                    Console.Write("a = ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second parameter b . ");
                    Console.Write("b = ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("The result of the equation is {0}. ", SolveAnEquation(a, b));
                    break;
                default:
                    Console.WriteLine("You've entered wrong option. ");
                    break;

            }
        }
        static String ReverseNumber(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number should be possitive or equal to 0.");
            }
            else
            {
                char[] reversedNumber = number.ToString().ToCharArray();
                Array.Reverse(reversedNumber);
                return new string(reversedNumber);
            }           
        }
        static int FindAverage(int[] array)
        {
            int average = 0;
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("The sequence should not be empty");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                average = sum / array.Length;
            }
            return average;
        }
        static double SolveAnEquation(double a, double b)
        {
            double result = 0;
            if (a == 0)
            {
                throw new ArgumentException("The number a shuold be different from 0");
            }
            else
            {
                result = (-b) / a;
            }
            return result;
        }
    }
}
