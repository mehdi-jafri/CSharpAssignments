using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class BoxingUnboxingDemo
    {
        // Method to demonstrate Boxing
        public void DemonstrateBoxing()
        {
            int value = 100;             // Value type (stored on stack)
            object obj = value;          // Boxing (value wrapped inside an object, stored on heap)

            Console.WriteLine("Boxing Example:");
            Console.WriteLine("Value type (int):"+ value);
            Console.WriteLine("Boxed object:"+obj);
            Console.WriteLine();
        }

        // Method to demonstrate Unboxing
        public void DemonstrateUnboxing()
        {
            object obj = 200;            // Boxed integerrequired  
            int value = (int)obj;        // Unboxing (explicit cast )

            Console.WriteLine("Unboxing Example:");
            Console.WriteLine("Boxed object:"+obj);
            Console.WriteLine("Unboxed value (int):" +value);
            Console.WriteLine();
        }

        // Combined demo method
        public void RunDemo()
        {
            DemonstrateBoxing();
            DemonstrateUnboxing();
        }

        static void Main(string[] args)
        {
            BoxingUnboxingDemo demo = new BoxingUnboxingDemo();
            demo.RunDemo();
        }
    }
}
