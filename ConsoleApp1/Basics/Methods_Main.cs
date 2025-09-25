using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class Methods_Main
    {
        static void Main(string[] args)
        {
            display();
            Methods m=new Methods();
            m.display();

            m.acceptName("John Doe");
            int result = m.num(5, 10);
            Console.WriteLine("Sum: " + result);

        }
        public static void display()
        {
            Console.WriteLine("Hello");
        }
    }
}
