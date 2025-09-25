using System;

namespace ConsoleApp1.Basics
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent class Show() method");
        }
    }

    class Child : Parent
    {
        // Shadowing the Show() method of Parent using 'new'
        public new void Show()
        {
            Console.WriteLine("Child class Show() method");
        }
    }

    internal class ShadowingDemo
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Show();  // Calls Parent version

            Child c = new Child();
            c.Show();  // Calls Child version

            Parent pc = new Child();
            pc.Show(); // Calls Parent version (because shadowing is compile-time, not runtime)

            Console.ReadLine();
        }
    }
}
