using System;

namespace ConsoleApp1.ExceptionHandling
{
    internal class ArrayIndexoutofRange
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };

                Console.WriteLine("Array Elements:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Element {i} = {numbers[i]}");
                }

                // Deliberately accessing an invalid index
                Console.WriteLine("\nTrying to access index 10...");
                Console.WriteLine(numbers[10]); // This will throw exception
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("⚠ Exception Caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\n✅ Program executed safely with exception handling.");
            }

            Console.ReadLine(); // Pause console so output remains visible
        }
    }
   
}
