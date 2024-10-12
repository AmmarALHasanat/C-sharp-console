using C__Learning.OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Abstraction
{
    internal abstract class ProgramBase 
    {
        // Abstract method - must be implemented in derived classes
        public abstract void Run();

        // Static method - this can call the Run method of the instance
        public static void RunProgram(ProgramBase program)
        {
            program.Run();
        }

    }
}
