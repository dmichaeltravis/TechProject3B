using System;

namespace TechProject3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int [25];
            // Store array values
            for (int index1 = 0; index1 < 25; index1++)
            {
                intArray[index1] = 2 * index1;
            }
            // Display Array values at Console
            for (int index1 = 0; index1 < 25; index1++)
            {
                Console.WriteLine("Array value " + index1 + " Equal to " + intArray[index1]);
            }
        }
    }
}
