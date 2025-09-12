using System;
using System.Linq;

namespace ConsoleApp1.Methods
{
    internal class Inbuilt_Reverse_Num_String
    {
        static void Main(string[] args)
        {
            // Reverse a Number
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();
            string reversedNumber = new string(numberInput.Reverse().ToArray());
            Console.WriteLine("Reversed Number: " + reversedNumber);

            // Reverse a String
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            string reversedString = new string(text.Reverse().ToArray());
            Console.WriteLine("Reversed String: " + reversedString);
        }
    }
}
