using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructors
{
    internal class Simple_PrivateConstructor
    {
        private static int count = 0;

        // Private constructor
        private Simple_PrivateConstructor()
        {
            count++;
            Console.WriteLine("Private constructor called. Count = " + count);
        }

        // Public static method to create instances inside the class
        public static Simple_PrivateConstructor CreateInstance()
        {
            return new Simple_PrivateConstructor();
        }
        static void Main()
        {

            // Use the public method to create instances
            Simple_PrivateConstructor e1 = Simple_PrivateConstructor.CreateInstance();
            Simple_PrivateConstructor e2 = Simple_PrivateConstructor.CreateInstance();

            // Output:
            // Private constructor called. Count = 1
            // Private constructor called. Count = 2
        }
    }
}
