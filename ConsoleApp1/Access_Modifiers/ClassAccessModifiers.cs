using System;

namespace ConsoleApp1.Access_Modifiers
{
    public class PublicClass
    {     // This class is accessible from anywhere in the project
        public void Show()
        {
            Console.WriteLine("Public Class");
        }
    }
    internal class InternalClass
    {// This class is accessible only within the same assembly (compiled project)
        public void Show()
        {
            Console.WriteLine("Default Internal Class");
        }
    }

    class DefaultInternalClass
    {     // --- Class with no modifier (default is internal) ---
        public void Show()
        {
            Console.WriteLine("Default Internal Class");
        }
    }
    /// <summary>
    ///                     THESE ARE THE ACCESS MODIFIERS FOR CLASSES WHICH CANNOT BE USED OUTSIDE THE CLASS
    /// </summary>
    //private class PrivateClass
    //{
    //    // This class is only accessible within the same file , not in same namespace or project, can be used inside nested classes
    //}
    //protected class ProtectedClass
    //{
    //    // This class is accessible within the same assembly and by derived classes
    //}
    //internal class InternalClass
    //{
    //    // This class is accessible within the same assembly
    //}
    //protected internal class ProtectedInternalClass
    //{
    //    // This class is accessible within the same assembly and by derived classes
    //}
    //private protected class PrivateProtectedClass
    //{
    //    // This class is accessible within the same assembly and by derived classes, but not outside the assembly
    //}

    public class PublicOuterClass
    {
        public class PublicNested
        { // Accessible anywhere
            public void Show()
            {
                Console.WriteLine("Public Outer Class + Nested Public Class");
            }
        }
        private class PrivateNested
        {  // Only OuterClass can use this
            public void Show()
            {
                Console.WriteLine("Public Outer Class + Nested Private Class");
            }
        }
        protected class ProtectedNested
        { // OuterClass + derived classes
            public void Show()
            {
                Console.WriteLine("Public Outer Class + Nested Protected Class");
            }
        }
        internal class InternalNested
        {  // Anywhere in the same assembly
            public void Show()
            {
                Console.WriteLine("Public Outer Class + Nested Internal Class");
            }
        }
        protected internal class ProtectedInternalNested
        { // Same assembly + derived classes
            public void Show()
            {
                Console.WriteLine("Public Outer Class + Nested Protected Internal Class");
            }

        }
        private protected class PrivateProtectedNested
        {  // Same assembly + derived classes (but not outside)
            public void Show()
            {
                Console.WriteLine("Public Outer Class + Nested Private Protected Class");
            }

        }

    }

    internal class InternalOuterClass
    {
        public class PublicNested
        { // Accessible anywhere
            public void Show()
            {
                Console.WriteLine("Internal Outer Class + Nested Public Class");
            }
        }
        private class PrivateNested
        {  // Only OuterClass can use this
            public void Show()
            {
                Console.WriteLine("Internal Outer Class + Nested Private Class");
            }
        }
        protected class ProtectedNested
        { // OuterClass + derived classes
            public void Show()
            {
                Console.WriteLine("Internal Outer Class + Nested Protected Class");
            }
        }
        internal class InternalNested
        {  // Anywhere in the same assembly
            public void Show()
            {
                Console.WriteLine("Internal Outer Class + Nested Internal Class");
            }
        }
        protected internal class ProtectedInternalNested
        { // Same assembly + derived classes
            public void Show()
            {
                Console.WriteLine("Internal Outer Class + Nested Protected Internal Class");
            }
        }
        private protected class PrivateProtectedNested
        {  // Same assembly + derived classes (but not outside)
            public void Show()
            {
                Console.WriteLine("Internal Outer Class + Nested Private Protected Class");
            }

        }
    }

    public class ClassAccessModifiers
    {
        static void Main(string[] args)
        {
            PublicClass publicClass = new PublicClass();
            publicClass.Show(); // Accessing public class

            InternalClass internalClass = new InternalClass();
            internalClass.Show(); // Accessing internal class

            DefaultInternalClass defaultInternalClass = new DefaultInternalClass();
            defaultInternalClass.Show(); // Accessing default internal class


            PublicOuterClass.PublicNested publicNested = new PublicOuterClass.PublicNested();
                                          publicNested.Show(); 
            PublicOuterClass.InternalNested internalNested = new PublicOuterClass.InternalNested();
                                            internalNested.Show(); 
           // PublicOuterClass.ProtectedNested protectedNested = new PublicOuterClass.ProtectedNested();
                                             // protectedNested.Show(); // Accessing protected nested class cannot be done since it is not accessible outside the class
            PublicOuterClass.ProtectedInternalNested protectedInternalNested = new PublicOuterClass.ProtectedInternalNested();
                                                     protectedInternalNested.Show(); // Accessing protected internal nested class can be done since it is accessible in the same assembly
           // PublicOuterClass.PrivateProtectedNested privateProtectedNested = new PublicOuterClass.PrivateProtectedNested();
                                                //    privateProtectedNested.Show(); // Accessing private protected nested class cannot be done since it is not accessible outside the class


            InternalOuterClass.PublicNested internalPublicNested = new InternalOuterClass.PublicNested();
                                            internalPublicNested.Show(); 
            InternalOuterClass.InternalNested internalNestedClass = new InternalOuterClass.InternalNested();
                                              internalNestedClass.Show(); 
            // InternalOuterClass.ProtectedNested internalProtectedNested = new InternalOuterClass.ProtectedNested();
                                             // internalProtectedNested.Show(); // Accessing protected nested class in internal is not allowed outside the class
            InternalOuterClass.ProtectedInternalNested internalProtectedInternalNested = new InternalOuterClass.ProtectedInternalNested();
                                               internalProtectedInternalNested.Show(); // Accessing protected internal nested class in internal
           // InternalOuterClass.PrivateProtectedNested internalPrivateProtectedNested = new InternalOuterClass.PrivateProtectedNested();
                                                //     internalPrivateProtectedNested.Show(); // Accessing private protected nested class in internal is not allowed outside the class

        }

    }
}
