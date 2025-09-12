using System;

namespace ConsoleApp1.Basics
{
    class Address2
    {
        public string City;
    }

    class Person2
    {
        public string Name;      // Reference type
        public int Age;          // Value type
        public Address2 Address;  // Reference type

        // Method for deep copy
        public Person2 DeepCopy()
        {
            Person2 clone = (Person2)this.MemberwiseClone(); // First, shallow copy
            clone.Address = new Address2();                 // Create new Address object
            clone.Address.City = this.Address.City;        // Copy value separately
            return clone;
        }
    }

    internal class DeepCopyDemo
    {
        static void Main(string[] args)
        {
            // Original person
            Person2 person1 = new Person2();
            person1.Name = "Alice";
            person1.Age = 25;
            person1.Address = new Address2 { City = "New York" };

            // Deep copy
            Person2 person2 = person1.DeepCopy();

            Console.WriteLine("Before change:");
            Console.WriteLine("Person1: " + person1.Name + ", " + person1.Age + ", " + person1.Address.City);
            Console.WriteLine("Person2: " + person2.Name + ", " + person2.Age + ", " + person2.Address.City);

            // Change person2 values
            person2.Name = "Bob";                // Independent
            person2.Age = 30;                    // Independent
            person2.Address.City = "Chicago";    // Independent now (deep copied)

            Console.WriteLine("\nAfter change:");
            Console.WriteLine("Person1: " + person1.Name + ", " + person1.Age + ", " + person1.Address.City);
            Console.WriteLine("Person2: " + person2.Name + ", " + person2.Age + ", " + person2.Address.City);
        }
    }
}
