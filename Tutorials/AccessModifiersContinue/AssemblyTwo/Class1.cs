using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            AssemblyTwoClass1 A1 = new AssemblyTwoClass1();
            A1.ID = 101;
            
        }
        
    }
}
