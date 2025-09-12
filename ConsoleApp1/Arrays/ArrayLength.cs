using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Arrays
{
    internal class ArrayLength
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        string[] names= { "Alice", "Bob", "Charlie", "David" };
        public void DisplayArrayLength()
        {
            // Display the length of the array
            Console.WriteLine("Length of the array: " + numbers.Length);
            Console.WriteLine("Length of the names array: " + names.Length);
        }
        static void Main(string[] args)
        {
            ArrayLength arrayLength = new ArrayLength();
            arrayLength.DisplayArrayLength(); // Calling the method to display the length of the arrays
        }
    }
}
