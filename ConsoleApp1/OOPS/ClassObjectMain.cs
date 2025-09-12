using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    internal class ClassObjectMain
    {
        public string name2 = "John";
        static void Main(string[] args)
        {
            //BasicClassObjects b = new BasicClassObjects();
            //string value1 = b.name;
            //int value2 = b.no;

            //Console.WriteLine("Name: " + value1 + "\n" + "Number: " + value2);

            ClassObjectMain o1 = new ClassObjectMain();
            string value = o1.name2;
            Console.WriteLine(value);

            o1.display(); 

            Child i=new Child();

        }

        public void display()
        {
            string value = name2; // Accessing the instance field directly  
            Console.WriteLine(value);
        }
    }
}
