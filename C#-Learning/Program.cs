using System;
using System.Drawing;
using System.Linq;
using C__Learning.OOP.Abstraction;
using EncapsulationProgram = C__Learning.OOP.Encapsulation.Program;
using AbstractionProgram = C__Learning.OOP.Abstraction.Program;
using InheritanceProgram = C__Learning.OOP.Inheritance.Program;
using PolymorphismProgram = C__Learning.OOP.Polymorphism.Program;
using Car;

// name space for using in other file like
namespace HelloWorld
{
    /**
     * This is a comment
     */
    class Program
    {
        static void Main(string[] args)
        {


            ProgramBase.RunProgram(new EncapsulationProgram());
            ProgramBase.RunProgram(new AbstractionProgram());
            ProgramBase.RunProgram(new InheritanceProgram());
            ProgramBase.RunProgram(new PolymorphismProgram());

        }
    }
}