using System;

namespace ConsoleApp1.Constructors
{
    class Person5
    {
        public string Name { get; set; }

        // Constructor
        public Person5(string name)
        {
            Name = name;
        }

        // Destructor
        ~Person5()
        {
            // Reset name to empty string
            Name = string.Empty;
            // Just for demonstration: print a message when destructor is called
            // (Note: destructor timing is nondeterministic)
            Console.WriteLine("Destructor called, Name reset.");
        }

        // Override ToString()
        public override string ToString()
        {
            return "Person's Name: " + Name;
        }
    }

    internal class PersonArrayDemo
    {
        static void Main()
        {
            Person5[] people = new Person5[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                string inputName = Console.ReadLine();
                people[i] = new Person5(inputName);
            }

            Console.WriteLine("\nYou entered:");
            foreach (Person5 p in people)
            {
                Console.WriteLine(p.ToString());
            }

            // Forcing garbage collection (not necessary but to demonstrate destructor)
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadLine();
        }
    }
}
