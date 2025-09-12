using System;

namespace ConsoleApp1.Control_Statements.Conditional_Blocks
{
    internal class IfElse_CheckGreatorNo
    {
        int n1, n2;

        public void checkNumber()
        {
            Console.Write("Enter Number 01:");
            n1=Convert.ToInt32(Console.ReadLine()); // Reads input from the console and converts it to an integer

            Console.Write("Enter Number 02:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Number 01 is greater than Number 02");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("Number 02 is greater than Number 01");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }
        }
    
        static void Main(string[] args)
        {
            IfElse_CheckGreatorNo o = new IfElse_CheckGreatorNo();
            o.checkNumber(); // Calling the method to check which number is greater
        }

    }
}
