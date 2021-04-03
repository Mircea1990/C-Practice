using System;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangular Array
            var cub = new int[10, 5, 14];

            var matrix = new[,]
            {
                {1,85,6,45},
                {74,9,57,34},
                {75,55,96,64}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Line({0}): ", i + 1);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" {matrix[i, j]}" + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //Jagged Array
            int[][] jagged =
            {
                new int[] {45,6,-4},
                new int[] {6,46,34,74},
                new int[] {2,-4,-84,42,65,321}

            };
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write("Line({0}): ", i + 1);
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
