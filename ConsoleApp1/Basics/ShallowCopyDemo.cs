using System;

namespace ConsoleApp1.Basics
{
//    ✅ Key rule to remember:
//Value types → copied separately.
//Reference types → only the reference (pointer) is copied, so both objects share the same data.
    class Address
    {
        public string City;
    }

    class Person
    {
        public string Name;      // Reference type
        public int Age;          // Value type
        public Address Address;  // Reference type

        // Shallow copy using MemberwiseClone()
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
    }
    internal class ShallowCopyDemo
    {
        static void Main(string[] args)
        {
            // Create original person
            Person person1 = new Person();
            person1.Name = "Alice";
            person1.Age = 25;
            person1.Address = new Address(); // Separate Address object , common reference type for both objects, any chages will reflect in both
            person1.Address.City = "New York";

            // Make a shallow copy
            Person person2 = person1.ShallowCopy();

            Console.WriteLine("Before change:");
            Console.WriteLine("Person1: " + person1.Name + ", " + person1.Age + ", " + person1.Address.City);
            Console.WriteLine("Person2: " + person2.Name + ", " + person2.Age + ", " + person2.Address.City);

            // Change values in person2
            person2.Name = "Bob";                // Separate
            person2.Age = 30;                    // Separate
            person2.Address.City = "Chicago";    // Shared → affects both

            Console.WriteLine("\nAfter change:");
            Console.WriteLine("Person1: " + person1.Name + ", " + person1.Age + ", " + person1.Address.City);
            Console.WriteLine("Person2: " + person2.Name + ", " + person2.Age + ", " + person2.Address.City);

        }
    }
}
