using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Arrays
{
    internal class ReverseArray
    {
        public void ReverseArrayMethod()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original Array: " + string.Join(", ", numbers));
            Array.Reverse(numbers); // Reverse the array
            Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));

            string[] names = { "Alice", "Bob", "Charlie", "David" };
            Console.WriteLine("Original Names Array: " + string.Join(", ", names));
            Array.Reverse(names); // Reverse the names array
            Console.WriteLine("Reversed Names Array: " + string.Join(", ", names));
        }

        public void ReverseArrayMethod2()
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();
            string reversedString = new string(input.Reverse().ToArray()); // here new string is used to create a new string from the reversed character array ,
                                                                           // ToArray () converts the reversed input to an array
            Console.WriteLine("Reversed String: " + reversedString);

            Console.WriteLine("Enter numbers separated by spaces to reverse:");
            string numberInput = Console.ReadLine();
            string numrev = new string(numberInput.Reverse().ToArray()); // Reverse the input string
            Console.WriteLine("Reversed Numbers: " +  numrev);
        }
        static void Main(string[] args)
        {
            ReverseArray reverseArray = new ReverseArray();
            reverseArray.ReverseArrayMethod(); // Calling the method to reverse the array
            reverseArray.ReverseArrayMethod2(); // Calling the method to reverse numbers and strings
        }
    }
}
