/* Write a program to convert hexadecimal numbers to binary numbers (directly).*/



using System;
using System.Collections.Generic;

namespace _05.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("N = ");
            String N = Console.ReadLine();
            Console.WriteLine(HexToBinery(N));


        }
        static String HexToBinery(String number)
        {
            String result = String.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(number[i]))
                {
                    switch (number[i])
                    {
                        case '0':
                            result = "0000" + result;
                            break;
                        case '1':
                            result = "0001" + result;
                            break;
                        case '2':
                            result = "0010" + result;
                            break;
                        case '3':
                            result = "0011" + result;
                            break;
                        case '4':
                            result = "0100" + result;
                            break;
                        case '5':
                            result = "0101" + result;
                            break;
                        case '6':
                            result = "0110" + result;
                            break;
                        case '7':
                            result = "0111" + result;
                            break;
                        case '8':
                            result = "1000" + result;
                            break;
                        case '9':
                            result = "1001" + result;
                            break;
                    }
                }
                else
                {
                    switch (number[i])
                    {
                        case 'A':
                            result = "1010" + result;
                            break;
                        case 'B':
                            result = "1011" + result;
                            break;
                        case 'C':
                            result = "1100" + result;
                            break;
                        case 'D':
                            result = "1101" + result;
                            break;
                        case 'E':
                            result = "1110" + result;
                            break;
                        case 'F':
                            result = "1111" + result;
                            break;
                    }
                }
            }
            return result;
        }
    }
}
