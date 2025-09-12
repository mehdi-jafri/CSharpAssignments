using System;

namespace ConsoleApp1.Access_Modifiers
{
    internal class MethodAccessModifiers
    {
        // --- Methods with different access specifiers ---
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method");
        }

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method");
        }

        // --- Show method calls from the same class ---
        public void ShowFromSameClass()
        {
            Console.WriteLine("=== Methods accessed inside same class ===");
            PublicMethod();
            PrivateMethod();
            ProtectedMethod();
            InternalMethod();
            ProtectedInternalMethod();
            PrivateProtectedMethod();
        }

        static void Main(string[] args)
        {
            MethodAccessModifiers baseObj = new MethodAccessModifiers();
            baseObj.ShowFromSameClass();

            MethodSubClass derivedObj = new MethodSubClass();
            derivedObj.ShowFromDerived();

            NonDerivedMethodClass nonDerivedObj = new NonDerivedMethodClass();
            nonDerivedObj.ShowFromNonDerived();

            Console.ReadLine();
        }
    }

    // --- Derived class ---
    internal class MethodSubClass : MethodAccessModifiers
    {
        public void ShowFromDerived()
        {
            Console.WriteLine("\n=== Methods accessed inside derived class (same assembly) ===");
            PublicMethod();              // ✅ public
            // PrivateMethod();          // ❌ private
            ProtectedMethod();           // ✅ protected
            InternalMethod();            // ✅ internal
            ProtectedInternalMethod();   // ✅ protected internal
            PrivateProtectedMethod();    // ✅ private protected
        }
    }

    // --- Non-derived class ---
    internal class NonDerivedMethodClass
    {
        public void ShowFromNonDerived()
        {
            MethodAccessModifiers obj = new MethodAccessModifiers();

            Console.WriteLine("\n=== Methods accessed inside non-derived class (same assembly) ===");
            obj.PublicMethod();           // ✅ public
            // obj.PrivateMethod();       // ❌ private
            // obj.ProtectedMethod();     // ❌ protected
            obj.InternalMethod();         // ✅ internal
            obj.ProtectedInternalMethod();// ✅ protected internal
            // obj.PrivateProtectedMethod(); // ❌ private protected
        }
    }
}
