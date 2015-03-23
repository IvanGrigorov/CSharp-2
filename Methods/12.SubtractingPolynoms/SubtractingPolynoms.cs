/* Extend the previous program to support also subtraction and multiplication of polynomials.*/



using System;


namespace _12.SubtractingPolynoms
{
    class SubtractingPolynoms
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
            Console.WriteLine("The added polynom is: ");
            for (int i = addedPolynoms.Length -1; i >= 0; i--)
            {
                Console.Write("({0}x^{1}) + ", addedPolynoms[i], i);
            }
            Console.WriteLine();
            int[] subractedPolynoms = SubtractingPolynomials(firstPolynom, secondPolynom);
            Console.WriteLine("The subtracted polynom is: ");
            for (int i = subractedPolynoms.Length - 1; i >= 0; i--)
            {
                Console.Write("({0}x^{1}) + ", subractedPolynoms[i], i);
            }
            Console.WriteLine();
            int[] multipliedPolynoms = MultiplingPolynoms(firstPolynom, secondPolynom);
            Console.WriteLine("The multiplied polynom is: ");
            for (int i = multipliedPolynoms.Length - 1; i >= 0; i--)
            {
                Console.Write("({0}x^{1}) + ", multipliedPolynoms[i], i);
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
        static int[] SubtractingPolynomials(int[] array1, int[] array2)
        {
            int max = Math.Max(array1.Length, array2.Length);
            int[] addedPolynoms = new int[max];
            if (array1.Length >= array2.Length)
            {
                array1.CopyTo(addedPolynoms, 0);
                for (int i = 0; i < array2.Length; i++)
                {
                    addedPolynoms[i] = addedPolynoms[i] - array2[i];
                }
            }
            else
            {
                array2.CopyTo(addedPolynoms, 0);
                for (int i = 0; i < array1.Length; i++)
                {
                    addedPolynoms[i] = addedPolynoms[i] - array1[i];
                }
            }
            return addedPolynoms;
        }
        static int[] MultiplingPolynoms(int[] array1, int[] array2)
        {
            int max = Math.Max(array1.Length, array2.Length);
            int[] addedPolynoms = new int[max];
            if (array1.Length >= array2.Length)
            {
                array1.CopyTo(addedPolynoms, 0);
                for (int i = 0; i < array2.Length; i++)
                {
                    addedPolynoms[i] = addedPolynoms[i] * array2[i];
                }
            }
            else
            {
                array2.CopyTo(addedPolynoms, 0);
                for (int i = 0; i < array1.Length; i++)
                {
                    addedPolynoms[i] = addedPolynoms[i] * array1[i];
                }
            }
            return addedPolynoms;
        }
    }
}
