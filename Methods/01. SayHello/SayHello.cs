/* Write a method that asks the user for his name and prints “Hello, <name>”
   Write a program to test this method.*/



using System;

namespace _01.SayHello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            AskName();
        }
        static void AskName()
        {
            Console.WriteLine("Please enter your name. ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, {0}. ", name);
        }
    }
}
