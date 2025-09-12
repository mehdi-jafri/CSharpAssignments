using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    public interface Interface1
    {
        void Method1(); // Method without body  

        // Removed default implementation to resolve CS8370 and CS8701 errors  
        void Method2();
    }
}
