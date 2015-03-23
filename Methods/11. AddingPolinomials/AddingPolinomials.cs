/* Write a method that adds two polynomials.
   Represent them as arrays of their coefficients.
   Example:
   x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}*/


using System;


namespace _11.AddingPolinomials
{
    class AddingPolinomials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum power of the first polynom. ");
            Console.Write("maxPower = ");
            int maxPower = int.Parse(Console.ReadLine());
            int[] firstPolynom = new int[maxPower + 1];
            Console.WriteLine("Enter the coefficients of the first polynom. ");
            for (int i = 0; i <= maxPower; i++)
            {
                Console.Write("Coefficient for x^{0} ", i);
                firstPolynom[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The first Polynom is: ");
            for (int i = maxPower; i >= 0; i--)
            {
                Console.Write("{0}x^{1} + ", firstPolynom[i], i);
            }
            Console.WriteLine();
            Console.WriteLine("Enter the maximum power of the second polynom. ");
            Console.Write("maxPower = ");
            int maxPower2 = int.Parse(Console.ReadLine());
            int[] secondPolynom = new int[maxPower2 + 1];
            Console.WriteLine("Enter the coefficients of the second polynom. ");
            for (int i = 0; i <= maxPower2; i++)
            {
                Console.Write("Coefficient for x^{0} ", i);
                secondPolynom[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The second Polynom is: ");
            for (int i = maxPower2; i >= 0; i--)
            {
                Console.Write("{0}x^{1} + ", secondPolynom[i], i);
            }
            Console.WriteLine();
            int[] addedPolynoms = AddingPolynoms(firstPolynom, secondPolynom);
            Console.WriteLine("The resulting polynom is: ");
            for (int i = addedPolynoms.Length -1; i >= 0; i--)
            {
                Console.Write("{0}x^{1} + ", addedPolynoms[i], i);
            }
        }
        static int[] AddingPolynoms(int[] array1, int[] array2)
        {
            int max = Math.Max(array1.Length, array2.Length);
            int[] addedPolynoms = new int[max];
            if (array1.Length >= array2.Length)
            {
                array1.CopyTo(addedPolynoms, 0);
                for (int i = 0; i < array2.Length; i++)
                {
                    addedPolynoms[i] = addedPolynoms[i] + array2[i];
                }
            }
            else
            {
                array2.CopyTo(addedPolynoms, 0);
                for (int i = 0; i < array1.Length; i++)
                {
                    addedPolynoms[i] = addedPolynoms[i] + array1[i];
                }
            }
            return addedPolynoms;            
        }
    }
}
