/* Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).*/



using System;
using System.Collections.Generic;

namespace _07.OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of system you are using (from 2 to 16). ");
            Console.Write("current = ");
            int current = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number you want to convert. ");
            Console.Write("N = ");
            String N = Console.ReadLine();
            Console.WriteLine("Enter the type of system you want to covert the number into (from 2 to 16). ");
            Console.Write("after = ");
            int after = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} with initial numeric system number {1} is the following number {2} in numeric system number {3}", N, current, NumericalSystemConverter(N, after, current), after);
        }
        static String NumericalSystemConverter(String number, int chosenSystem, int currentSystem)
        {
            int N = 0;
            int pow = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                N += (int)(number[i] - '0') * (int)(Math.Pow(currentSystem, pow));
                pow--;
            }
            List<object> Representation = new List<object>();
            while (N > 0)
            {
                switch (N % chosenSystem)
                {
                    case 0:
                        Representation.Add(0);
                        N = N / chosenSystem;
                        break;
                    case 1:
                        Representation.Add(1);
                        N = N / chosenSystem;
                        break;
                    case 2:
                        Representation.Add(2);
                        N = N / chosenSystem;
                        break;
                    case 3:
                        Representation.Add(3);
                        N = N / chosenSystem;
                        break;
                    case 4:
                        Representation.Add(4);
                        N = N / chosenSystem;
                        break;
                    case 5:
                        Representation.Add(5);
                        N = N / chosenSystem;
                        break;
                    case 6:
                        Representation.Add(6);
                        N = N / chosenSystem;
                        break;
                    case 7:
                        Representation.Add(7);
                        N = N / chosenSystem;
                        break;
                    case 8:
                        Representation.Add(8);
                        N = N / chosenSystem;
                        break;
                    case 9:
                        Representation.Add(9);
                        N = N / chosenSystem;
                        break;
                    case 10:
                        Representation.Add('A');
                        N = N / chosenSystem;
                        break;
                    case 11:
                        Representation.Add('B');
                        N = N / chosenSystem;
                        break;
                    case 12:
                        Representation.Add('C');
                        N = N / chosenSystem;
                        break;
                    case 13:
                        Representation.Add('D');
                        N = N / chosenSystem;
                        break;
                    case 14:
                        Representation.Add('E');
                        N = N / chosenSystem;
                        break;
                    case 15:
                        Representation.Add('F');
                        N = N / chosenSystem;
                        break;
                }
            }
            Representation.Reverse();
             return (String.Join("", Representation.ToArray()));
        }
    }
}
