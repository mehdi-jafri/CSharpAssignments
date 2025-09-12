using System;

namespace ConsoleApp1.ExceptionHandling
{
    internal class DivideByZero
    {
        static void Main(string[] args)
        {
            int numerator, denominator, result;

            Console.Write("Enter numerator: ");
            numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            denominator = Convert.ToInt32(Console.ReadLine());

            try
            {
                // Attempt division
                result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                // Handle divide by zero exception
                Console.WriteLine("Error: Cannot divide by zero!");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            finally
            {
                // Always executes
                Console.WriteLine("Division attempt finished.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
