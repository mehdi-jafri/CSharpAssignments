using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class Operators
    {
        public void BasicOperators()
        {
            // Operators are special symbols that perform operations on variables and values.
            Console.WriteLine("Operators Example");
            Console.WriteLine("-----------------------");

            // 1) Arithmetic Operators
            int a = 10, b = 20;
            Console.WriteLine("Addition: " + (a + b)); // Output: 30
            Console.WriteLine("Subtraction: " + (b - a)); // Output: 10
            Console.WriteLine("Multiplication: " + (a * b)); // Output: 200
            Console.WriteLine("Division: " + (b / a)); // Output: 2

            //int n1 = 10;
            //int n2 = 20;
            //double res = n1 / n2;
            //Console.WriteLine(res); // Output: 0.0 , since division returns point result

            //double res2 = (double) n1 / n2; // casting n1 to double ie the no to divide with 
            //Console.WriteLine(res2); // Output: 0.5 , since we cast n1 to double before division

            Console.WriteLine("Modulus: " + (b % a)); // Output: 0

            // 2) Comparison Operators
            Console.WriteLine("Is a equal to b? " + (a == b)); // Output: False
            Console.WriteLine("Is a not equal to b? " + (a != b)); // Output: True
            Console.WriteLine("Is a greater than b? " + (a > b)); // Output: False
            Console.WriteLine("Is a less than b? " + (a < b)); // Output: True

            // 3) Logical Operators
            bool x = true, y = false;
            Console.WriteLine("Logical AND: " + (x && y)); // Output: False
            Console.WriteLine("Logical OR: " + (x || y)); // Output: True
            Console.WriteLine("Logical NOT x: " + (!x)); // Output: False

            Console.WriteLine("Logical NOT y: " + (!y)); // Output: True

            // 4) Assignment Operators
            int c = 5;
            c += 3; // Equivalent to c = c + 3
            Console.WriteLine("c after += 3: " + c); // Output: 8
            c -= 2; // Equivalent to c = c - 2
            Console.WriteLine("c after -= 2: " + c); // Output: 6
            c *= 2; // Equivalent to c = c * 2
            Console.WriteLine("c after *= 2: " + c); // Output: 12
            c /= 3; // Equivalent to c = c / 3
            Console.WriteLine("c after /= 3: " + c); // Output: 4
            c %= 2; // Equivalent to c = c % 2
            Console.WriteLine("c after %= 2: " + c); // Output: 0

            // 5) Unary Operators
            int d = 5;
            Console.WriteLine("Pre-increment: " + (++d)); // Output: 6
            Console.WriteLine("Post-increment: " + (d++)); // Output: 6 (then d becomes 7)
            Console.WriteLine("Value of d after post-increment: " + d); // Output: 7
            Console.WriteLine("Pre-decrement: " + (--d)); // Output: 6
            Console.WriteLine("Post-decrement: " + (d--)); // Output: 6 (then d becomes 5)
            Console.WriteLine("Value of d after post-decrement: " + d); // Output: 5
            Console.WriteLine("-----------------------");
            Console.WriteLine("End of Operators Example"
            );

        }
        public void AdditionalOperators()
        {
            string name = "John";
            Console.WriteLine(name.Length);  // Output: 4
            Console.WriteLine(name.ToLower()); // Output: john
            Console.WriteLine(name.ToUpper()); // Output: JOHN

            string text = "Hello, World!";
            Console.WriteLine(text.IndexOf("World")); // Output: 7
        }
    }
}
