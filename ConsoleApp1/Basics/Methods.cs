using System;

namespace ConsoleApp1.Basics
{
    internal class Methods
    {
        public void display()
        {
            Console.WriteLine("Hello");
        }

        public void acceptName(string name)
        {
            Console.WriteLine("Name: " + name);
        }

        public int num(int a, int b)
        {
            return a + b;
        }

    }
}
