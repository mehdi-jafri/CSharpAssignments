using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class TypeCasting
    {
        public void display()
        {
            // Type casting is the process of converting a variable from one type to another.
            Console.WriteLine("Type Casting Example");
            Console.WriteLine("-----------------------");
            Console.WriteLine("STRING TO INT CONVERSION");        //STRING TO INT CONVERSION
                    string age = "32";
                    int age2 = Int32.Parse(age);
                    Console.WriteLine(age2);

            Console.WriteLine();

            Console.WriteLine("DOUBLE TO INT CONVERSION");        //DOUBLE TO INT CONVERSION
                    double age3 = 9.78858585995;
                    int age4 = (int)age3;
                    Console.WriteLine(age4);

            Console.WriteLine();

            Console.WriteLine("INT TO STRING CONVERSION");        //INT TO STRING CONVERSION
                    int age5 = 10;
                    string age6 = age5.ToString();
                    Console.WriteLine(age6);
        }

    }
}
