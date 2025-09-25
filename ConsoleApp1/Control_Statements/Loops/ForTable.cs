using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Control_Statements.Loops
{
    internal class ForTable
    {
           public void displayTable()
        {
            int n = 5;
            Console.WriteLine("Table of 5: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n+"*"+i+"=" + (5 * i));
            }
        }
    }
}
