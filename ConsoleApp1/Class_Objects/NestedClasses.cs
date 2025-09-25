using System;

namespace ConsoleApp1.Class_Objects
{
    internal class NestedClasses
    {
        public class OuterClass
        {
            public class InnerClass
            {
                public void DisplayMessage()
                {
                    Console.WriteLine("Hello from the Inner Class!");
                }
            }
        }

        static void Main(string[] args)
         {
            OuterClass.InnerClass inner = new OuterClass.InnerClass();    // Create an instance of the InnerClass
                                    // Call the method to display the message
            inner.DisplayMessage(); // Output: Hello from the Inner Class!
           
            OuterClass outer = new OuterClass(); // You can also create an instance of the OuterClass if needed
            Console.WriteLine("Outer class instance created successfully.");
                                                  // Note: The OuterClass instance is not strictly necessary for this example,
                                                 // but it demonstrates how to instantiate the outer class if needed.
                                                // You can also access the InnerClass directly without an instance of OuterClass
          }
        }
    }
