using System;

namespace ConsoleApp1.OOPS.Polymorphism
{
    internal class Overriding
    {
        static void Main(string[] args)
        {
            //Settings s = new Settings(); // Creating an object of the base class / single class Settings
            Settings t = new Tab(); // Creating an object of the derived class Tab with settings class reference
            t.ScreenType(); 
            t.ScreenSize(); // Calling the overridden method from the derived class Tab
           
            Settings tv = new Tv(); // Creating an object of the derived class Tv with settings class reference
            tv.ScreenType(); // Calling the method from the base class Settings
            tv.ScreenSize(); // Calling the method from the derived class Tv
        }
    }

    public class Settings 
    {
        public virtual void ScreenSize()  // virtual says that we can override this method in derived classes
        {
            Console.WriteLine("Default Screen Size : 1080 x 1920");
        }

        public virtual void ScreenType() // Default implementation
        {
            Console.WriteLine("Default Screen Type : LCD");
        }
        
    }

    public class Tab : Settings
    {
        public override void ScreenSize()  // override says that we are providing a new implementation for this method
        {
            Console.WriteLine("Default Screen Size : 2080 x 2920");
        }

        public override void ScreenType()
        {
            Console.WriteLine("Default Screen Type : OLED");
        }
    }

    public class Tv : Settings
    {
        public override void ScreenSize()
        {
            Console.WriteLine("Default Screen Size : 4080 x 4920");
        }
    }
}
