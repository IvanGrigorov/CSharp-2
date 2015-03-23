/* Write a program to convert decimal numbers to their hexadecimal representation.*/



using System;
using System.Collections.Generic;


namespace _03.DecimalTo_Hexaecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            List<object> hexRepresentation = new List<object>();
            while (N > 0)
            {
                switch (N % 16)
                {
                    case 0:
                        hexRepresentation.Add(0);
                        N = N / 16;
                        break;
                    case 1:
                        hexRepresentation.Add(1);
                        N = N / 16;
                        break;
                    case 2:
                        hexRepresentation.Add(2);
                        N = N / 16;
                        break;
                    case 3:
                        hexRepresentation.Add(3);
                        N = N / 16;
                        break;
                    case 4:
                        hexRepresentation.Add(4);
                        N = N / 16;
                        break;
                    case 5:
                        hexRepresentation.Add(5);
                        N = N / 16;
                        break;
                    case 6:
                        hexRepresentation.Add(6);
                        N = N / 16;
                        break;
                    case 7:
                        hexRepresentation.Add(7);
                        N = N / 16;
                        break;
                    case 8:
                        hexRepresentation.Add(8);
                        N = N / 16;
                        break;
                    case 9:
                        hexRepresentation.Add(9);
                        N = N / 16;
                        break;
                    case 10:
                        hexRepresentation.Add('A');
                        N = N / 16;
                        break;
                    case 11:
                        hexRepresentation.Add('B');
                        N = N / 16;
                        break;
                    case 12:
                        hexRepresentation.Add('C');
                        N = N / 16;
                        break;
                    case 13:
                        hexRepresentation.Add('D');
                        N = N / 16;
                        break;
                    case 14:
                        hexRepresentation.Add('E');
                        N = N / 16;
                        break;
                    case 15:
                        hexRepresentation.Add('F');
                        N = N / 16;
                        break;                    
                }                
            }
            hexRepresentation.Reverse();
            Console.WriteLine(String.Join("", hexRepresentation.ToArray()));
        }
    }
}
