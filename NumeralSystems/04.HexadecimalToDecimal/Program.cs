/* Write a program to convert hexadecimal numbers to their decimal representation.*/



using System;


namespace _04.HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("N = ");
            String N = Console.ReadLine();
            int result = 0;
            int pow = N.Length - 1;
            for (int i = 0; i < N.Length; i++)
            {
                result += HexConverter(N[i]) * (int)(Math.Pow(16, pow));
                pow--;
            }
            Console.WriteLine(result);
        }
        static int HexConverter(char a)
        {
            switch (a)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    return 0;
            }                
        }
    }
}
