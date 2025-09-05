using System;
using System.Drawing;
using System.Linq;
using C__Learning.OOP.Abstraction;
using EncapsulationProgram = C__Learning.OOP.Encapsulation.Program;
using AbstractionProgram = C__Learning.OOP.Abstraction.Program;
using InheritanceProgram = C__Learning.OOP.Inheritance.Program;
using PolymorphismProgram = C__Learning.OOP.Polymorphism.Program;
using RefProgram = C__Learning.Ref.Program;
using CompositionProgram = C__Learning.OOP.Composition.Program;
using ExceptionProgram = C__Learning.ExceptionHandling.Program;
using ExampleProgram = C__Learning.OOP.Example.Program;
// name space for using in other file like
namespace C__Learning
{
    /**
     * This is a comment
     */
    class Program
    {
        static void Main(string[] args)
        {

            //ProgramBase.RunProgram(new EncapsulationProgram());
            //ProgramBase.RunProgram(new AbstractionProgram());
            //ProgramBase.RunProgram(new InheritanceProgram());
            //ProgramBase.RunProgram(new PolymorphismProgram());
            //ProgramBase.RunProgram(new RefProgram());
            //ProgramBase.RunProgram(new CompositionProgram());
            //ProgramBase.RunProgram(new ExceptionProgram());
            //ProgramBase.RunProgram( new ExampleProgram());

            var programs = new ProgramBase[]
            {
                new EncapsulationProgram(),
                new AbstractionProgram(),
                new InheritanceProgram(),
                new PolymorphismProgram(),
                new RefProgram(),
                new CompositionProgram(),
                new ExceptionProgram(),
                new ExampleProgram()
            };
            //foreach (var program in programs)
            //{
            //    ProgramBase.RunProgram(program);
            //}


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}