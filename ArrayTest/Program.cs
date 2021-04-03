using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            int[] intArray;

            // allocation
            intArray = new int[10];

            // declaration and assignment
            var doubleArray = new[] { 10.45, 78.35, -4.7, 56.24 };

            //Accessing elements
            var elemet = doubleArray[0];
            doubleArray[1] = -64.12;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            Console.WriteLine("\n");
            foreach (var value in doubleArray)
            {

                Console.Write(value + "   ");
            }

            Console.WriteLine("\n");
            Array.Sort(doubleArray);
            foreach(var value2 in doubleArray)
            {
                Console.Write(value2 + "  ");
            }

            Console.WriteLine("\n");
            for(int i = 0; i< doubleArray.Length; i++)
            {
                Console.WriteLine("doubleArray[{0}] = {1}", i, doubleArray[i]);
            }
        }
    }
}
