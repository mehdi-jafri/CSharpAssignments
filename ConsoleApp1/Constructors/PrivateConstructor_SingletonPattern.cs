using System;

namespace ConsoleApp1.Constructors
{
 
    class Logger
    {
        private static Logger instance = null;

        // Private constructor
        private Logger()
        {
            Console.WriteLine("Logger constructor called.");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

    internal class PrivateConstructor_SingletonPattern
    {
        static void Main()
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("First log entry.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second log entry.");

            Console.WriteLine(Object.ReferenceEquals(logger1, logger2));  // True - same instance
        }
    }
}
