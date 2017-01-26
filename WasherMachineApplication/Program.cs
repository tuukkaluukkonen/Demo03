using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherMachineApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WasherMachine washermachine = new WasherMachine();
            washermachine.IsOn = true;
            washermachine.Program = "valkopyykki";
            washermachine.Watertemp = 60;
            washermachine.ProgramLenght = 60;

            washermachine.StartProgram();

            Console.WriteLine("Program is " + washermachine.Program);
            Console.WriteLine("watertemp is " + washermachine.Watertemp);
            Console.WriteLine("Program lenght is " + washermachine.ProgramLenght);


        }
    }
}
