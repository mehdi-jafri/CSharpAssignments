using System;

namespace ConsoleApp1.Methods
{
    public class Person
    {
        private string name;
        private int age;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative");
            }
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

    }

    public class Person2
    {
        private string name;
        private int age;
        public string Name // using properties and their hidden gettter and setter methods 
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                age = value;
            }
        }
    }
    internal class Getters_Setters
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("Alice");
            person.SetAge(30);
            Console.WriteLine("Name: " + person.GetName());
            Console.WriteLine("Age: " + person.GetAge());
            // Uncommenting the following line will throw an exception
            // person.SetAge(-5); // This will throw an exception because age cannot be negative

            Person2 person2 = new Person2();
            person2.Name = "Bob"; // Using property to set name
            person2.Age = 25; // Using property to set age
            Console.WriteLine("Name: " + person2.Name); // Using property to get name
            Console.WriteLine("Age: " + person2.Age); // Using property to get age
            // Uncommenting the following line will throw an exception
            // person2.Age = -10; // This will throw an exception because age cannot be negative
        }
    }
}
