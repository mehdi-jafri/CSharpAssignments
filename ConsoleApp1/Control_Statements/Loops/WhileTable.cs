using System;

namespace ConsoleApp1.Control_Statements.Loops
{
    internal class WhileTable
    {
          public void displayTable()
        {
            int n = 5;
            int i = 1;
            
            Console.WriteLine("Table of 5: ");
            
            while (i <= 10)
            {
                Console.WriteLine(n + "*" + i + "=" + (5 * i));
                i++;
            }
        }

        static void Main(string[] args)
        {
            WhileTable whileTable = new WhileTable();
            whileTable.displayTable(); // Calling the method to display the table of 5
        }
    }
}
