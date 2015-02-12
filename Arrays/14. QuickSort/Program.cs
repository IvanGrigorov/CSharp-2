/* Write a program that sorts an array of integers using the Quick sort algorithm.*/

/* For this Problem I used the following algorithm:
 quicksort(A, lo, hi):
  if lo < hi:
    p := partition(A, lo, hi)
    quicksort(A, lo, p - 1)
    quicksort(A, p + 1, hi)
 
 
 // lo is the index of the leftmost element of the subarray
  // hi is the index of the rightmost element of the subarray (inclusive)
  partition(A, lo, hi)
     pivotIndex := choosePivot(A, lo, hi)
     pivotValue := A[pivotIndex]
     // put the chosen pivot at A[hi]
     swap A[pivotIndex] and A[hi]
     storeIndex := lo
     // Compare remaining array elements against pivotValue = A[hi]
     for i from lo to hi−1, inclusive
         if A[i] ≤ pivotValue
             swap A[i] and A[storeIndex]
             storeIndex := storeIndex + 1
     swap A[storeIndex] and A[hi]  // Move pivot to its final place
     return storeIndex  */


using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the list. ");
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("arr1[{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Quicksort(arr1, 0, length - 1);
            foreach (int x in arr1)
            {
                Console.WriteLine("{0}, ", x);
            }
        }
        public static int Partition(int[] array, int start, int final)
        {
            int pivotIndeks = 2; //You can make a method which can choose the best element for a pivot 
            int pivot = array[pivotIndeks];
            int tmp3 = array[pivotIndeks];
            array[pivotIndeks] = array[final];
            array[final] = tmp3;
            int stroredIndeks = start;
            for (int i = start; i < final; i++)
            {
                if (array[i] <= pivot)
                {
                    int tmp = array[i];
                    array[i] = array[stroredIndeks];
                    array[stroredIndeks] = tmp;
                    stroredIndeks++;
                }
            }
            int tmp2 = array[final];
            array[final] = array[stroredIndeks];
            array[stroredIndeks] = tmp2;
            return stroredIndeks;
        }
        public static void Quicksort(int[] array, int start, int final)
        {
            if (start < final)
            {
                int pivot = Partition(array, start, final);
                Quicksort(array, start, pivot - 1);
                Quicksort(array, pivot + 1, final);
            }
        }
    }
}