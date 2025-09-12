using System;
using System.Security.AccessControl;

namespace ConsoleApp1.Access_Modifiers
{
    // Base class with all access modifiers
    internal class VariablesAccessModifiers
    {
        public string publicVariable = "Public Variable";   // Public variable: Accessible from anywhere
        private string privateVariable = "Private Variable"; // Private variable: Accessible only within this class
        protected string protectedVariable = "Protected Variable"; // Protected variable: Accessible within this class and derived classes
        internal string internalVariable = "Internal Variable"; // Internal variable: Accessible within the same assembly
        protected internal string protectedInternalVariable = "Protected Internal Variable"; // Protected internal variable: Accessible within the same assembly and derived classes
        private protected string privateProtectedVariable = "Private Protected Variable"; // same class or derived classes in the same assembly only (added in C# 7.2)

        public readonly string readonlyVariable = "Readonly Variable";  // Readonly variable: Can only be assigned at declaration or in the constructor
        public const string constantVariable = "Constant Variable";    // Constant variable: Cannot be changed after declaration
        public static string staticVariable = "Static Variable";      // Static variable: Belongs to the class, not to any specific instance these all  

        public void ShowFromSameClass()
        {
            Console.WriteLine("=== Access inside same class ===");
            Console.WriteLine(publicVariable);
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(privateProtectedVariable);
            Console.WriteLine(readonlyVariable);
            Console.WriteLine(constantVariable);
            Console.WriteLine(staticVariable);
        }

        static void Main(string[] args)
        {
            VariablesAccessModifiers baseObj = new VariablesAccessModifiers();
            baseObj.ShowFromSameClass();

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.ShowFromDerived();

            NonDerivedClass nonDerivedObj = new NonDerivedClass();
            nonDerivedObj.ShowFromNonDerived();

            Console.ReadLine();
        }
    }

    // Derived class in same assembly
    internal class DerivedClass : VariablesAccessModifiers
    {
        public void ShowFromDerived()
        {
            Console.WriteLine("\n=== Access inside derived class (same assembly) ===");
            Console.WriteLine(publicVariable);                // ✅ public
            // Console.WriteLine(privateVariable);           // ❌ private - not accessible
            Console.WriteLine(protectedVariable);             // ✅ protected
            Console.WriteLine(internalVariable);              // ✅ internal (same assembly)
            Console.WriteLine(protectedInternalVariable);     // ✅ protected internal
            Console.WriteLine(privateProtectedVariable);      // ✅ private protected (same assembly + derived)
            Console.WriteLine(readonlyVariable);              // ✅ public readonly
            Console.WriteLine(constantVariable);              // ✅ public const
            Console.WriteLine(staticVariable);                // ✅ public static
        }
    }

    // Non-derived class in same assembly
    internal class NonDerivedClass
    {
        public void ShowFromNonDerived()
        {
            VariablesAccessModifiers obj = new VariablesAccessModifiers();

            Console.WriteLine("\n=== Access inside non-derived class (same assembly) ===");
            Console.WriteLine(obj.publicVariable);            // ✅ public
            // Console.WriteLine(obj.privateVariable);        // ❌ private - not accessible
            // Console.WriteLine(obj.protectedVariable);      // ❌ protected - not accessible
            Console.WriteLine(obj.internalVariable);          // ✅ internal
            Console.WriteLine(obj.protectedInternalVariable); // ✅ protected internal
            // Console.WriteLine(obj.privateProtectedVariable);// ❌ private protected - not accessible
            Console.WriteLine(obj.readonlyVariable);          // ✅ public readonly
            Console.WriteLine(VariablesAccessModifiers.constantVariable); // ✅ const  directly accessed from class name because it's static
            Console.WriteLine(VariablesAccessModifiers.staticVariable);   // ✅ static directly accessed from class name because it's static
        }
    }
}
