using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructors
{
    class Counter
    {
        public static int Count;

        // Static constructor
        static Counter()
        {
            Count = 100;
            Console.WriteLine("Static constructor called.");
        }

        public static void DisplayCount()
        {
            Console.WriteLine("Count: " + Count);
        }
    }

    internal class Static_Constructor
    {
        static void Main()
        {
            Counter.DisplayCount();  // Static constructor called before this
        }
    }
}
