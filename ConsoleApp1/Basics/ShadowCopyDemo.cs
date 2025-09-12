using System;
using System.Reflection;

namespace ConsoleApp1.Basics
{
    internal class ShadowCopyDemo
    {
        static void Main(string[] args)
        {
            // Create a new AppDomain
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;

            // Enable shadow copying
            setup.ShadowCopyFiles = "true";

            // Create a new AppDomain with shadow copy enabled
            AppDomain domain = AppDomain.CreateDomain("ShadowCopyDomain", null, setup);

            Console.WriteLine("Shadow copy enabled in AppDomain:");
            Console.WriteLine("Base Directory: " + setup.ApplicationBase);
            Console.WriteLine("Shadow Copy Files: " + setup.ShadowCopyFiles);

            // Load an assembly (for example, mscorlib just for demo)
            Assembly asm = typeof(object).Assembly;
            Console.WriteLine("Loaded Assembly: " + asm.FullName);

            // Unload the domain (original assembly not locked)
            AppDomain.Unload(domain);

            Console.WriteLine("AppDomain unloaded. Original assemblies are not locked due to shadow copy.");
        }
    }
}
