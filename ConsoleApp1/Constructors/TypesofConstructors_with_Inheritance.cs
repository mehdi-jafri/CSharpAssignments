using System;

namespace ConsoleApp1.Constructors
{
    class BaseClass
    {
        public int x, y;

        // Static constructor
        static BaseClass()
        {
            Console.WriteLine("BaseClass static constructor called.");
        }

        // Default constructor
        public BaseClass()
        {
            x = 0;
            y = 0;
            Console.WriteLine("BaseClass default constructor called.");
        }

        // Parameterized constructor
        public BaseClass(int a, int b)
        {
            x = a;
            y = b;
            Console.WriteLine("BaseClass parameterized constructor called.");
        }

        // Copy constructor (user-defined)
        public BaseClass(BaseClass obj)
        {
            x = obj.x;
            y = obj.y;
            Console.WriteLine("BaseClass copy constructor called.");
        }

        public void Display()
        {
            Console.WriteLine($"BaseClass values: x = {x}, y = {y}");
        }
    }

    class DerivedClass : BaseClass
    {
        public int z;

        // Static constructor
        static DerivedClass()
        {
            Console.WriteLine("DerivedClass static constructor called.");
        }

        // Default constructor calls base default constructor
        public DerivedClass() : base()
        {
            z = 0;
            Console.WriteLine("DerivedClass default constructor called.");
        }

        // Parameterized constructor chaining to base parameterized constructor
        public DerivedClass(int a, int b, int c) : base(a, b)
        {
            z = c;
            Console.WriteLine("DerivedClass parameterized constructor called.");
        }

        // Copy constructor chaining to base copy constructor
        public DerivedClass(DerivedClass obj) : base(obj)
        {
            z = obj.z;
            Console.WriteLine("DerivedClass copy constructor called.");
        }

        public void DisplayAll()
        {
            Display(); // Base class display
            Console.WriteLine($"DerivedClass value: z = {z}");
        }
    }

    // Singleton class demonstrating private constructor
    class Singleton
    {
        private static Singleton instance = null;

        public int Data { get; set; }

        // Private constructor
        private Singleton()
        {
            Data = 100;
            Console.WriteLine("Singleton private constructor called.");
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
                Console.WriteLine("Singleton instance created.");
            }
            else
            {
                Console.WriteLine("Singleton instance already exists.");
            }
            return instance;
        }
    }

    class TypesofConstructors_with_Inheritance
    {
        static void Main()
        {
            Console.WriteLine("Creating BaseClass object with default constructor:");
            BaseClass base1 = new BaseClass();
            base1.Display();

            Console.WriteLine("\nCreating BaseClass object with parameterized constructor:");
            BaseClass base2 = new BaseClass(10, 20);
            base2.Display();

            Console.WriteLine("\nCreating BaseClass object with copy constructor:");
            BaseClass base3 = new BaseClass(base2);
            base3.Display();

            Console.WriteLine("\nCreating DerivedClass object with default constructor:");
            DerivedClass derived1 = new DerivedClass();
            derived1.DisplayAll();

            Console.WriteLine("\nCreating DerivedClass object with parameterized constructor:");
            DerivedClass derived2 = new DerivedClass(30, 40, 50);
            derived2.DisplayAll();

            Console.WriteLine("\nCreating DerivedClass object with copy constructor:");
            DerivedClass derived3 = new DerivedClass(derived2);
            derived3.DisplayAll();

            Console.WriteLine("\nUsing Singleton class with private constructor:");
            Singleton s1 = Singleton.GetInstance();
            Console.WriteLine($"Singleton Data: {s1.Data}");

            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine($"Singleton Data: {s2.Data}");

            Console.ReadLine();
        }
    }

}
