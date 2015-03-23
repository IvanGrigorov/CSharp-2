/* 
    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
*/



using System;

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose wich method you want to use. ");
            Console.WriteLine("1 is for side and altitude. ");
            Console.WriteLine("2 is for Heron's formula. ");
            Console.WriteLine("3 is for two sides and the angle between them. ");
            Console.Write("Choice = ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose side and altitude.");
                    Console.WriteLine("Enter lengths. ");
                    Console.Write("a = ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("altitude = ");
                    double altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine("The suface is {0}", Surface(a, altitude));
                    break;
                case 2:
                    Console.WriteLine("You chose Heron's formula.");
                    Console.WriteLine("Enter lengths. ");
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine("The suface is {0}", HeronFormula(a, b, c));
                    break;
                case 3:
                    Console.WriteLine("You chose two sides and angle.");
                    Console.WriteLine("Enter lengths and angle. ");
                    Console.Write("a = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("angle = ");
                    double angle = double.Parse(Console.ReadLine());
                    Console.WriteLine("The suface is {0}", Surface(a, b, angle));
                    break;
            }
        }
        static double Surface(double side, double altitude)
        {
            double surface = (side * altitude) / 2;
            return surface;
        }
        static double HeronFormula(double side1, double side2, double side3)
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            double surface = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            return surface;
        }
        static double Surface(double side1, double side2, double angle)
        {
            double surface = (side1 * side2 * (Math.Sin(Math.PI * angle / 180)) / 2);
            return surface;
        }

    }
}
