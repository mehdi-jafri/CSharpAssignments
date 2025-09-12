using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Methods
{
    internal class Table_UserdefinedNum_Readline_Convert
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to display its table: ");
            int number = Convert.ToInt32(Console.ReadLine()); // Read & convert to int

            Console.WriteLine("\nMultiplication Table of number:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number +"x"+ i +"="+ number * i);
            }
        }
    }
}
