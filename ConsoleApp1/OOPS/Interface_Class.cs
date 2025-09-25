using System;

namespace ConsoleApp1.OOPS
{
  
    internal class Interface_Class : Interface1, Interface2
    {
        // Implement display from Interface2
        public void display()
        {
            Console.WriteLine("This is Implemented display method of Interface 2");
        }

        // Implement Method1 from Interface1
        public void Method1()
        {
            Console.WriteLine("This is Implemented Method1 of Interface 1");
        }

        // Implement Method2 from Interface1
        public void Method2()
        {
            Console.WriteLine("This is Implemented Method2 of Interface 1");
        }

        // If needed, a private method
        private void SomePrivateMethod()
        {
            // Private method inside class
        }

        static void Main(string[] args)
        {
            Interface_Class interfaceClass = new Interface_Class();
            interfaceClass.Method1(); // Calling the method from Interface1
            interfaceClass.Method2(); // Calling the method from Interface1
            interfaceClass.display();   // Calling the method from Interface2
        }
    }
}