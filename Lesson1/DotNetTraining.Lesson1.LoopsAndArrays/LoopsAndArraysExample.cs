using System;
using System.Collections.Generic;

namespace DotNetTraining.Lesson1.LoopsAndArrays
{
    public class LoopsAndArraysExample
    {
        public void PrintLoopsExample()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }

            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);

            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}");
        }

        public void ArraysExample()
        {
            // Declare a single-dimensional array. 
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
    }
}