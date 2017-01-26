using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherMachineApplication
{
    class WasherMachine
    {
        public bool IsOn { get; set; }
        public string Program { get; set; }
        public int Watertemp { get; set; }
        public int ProgramLenght { get; set; }

        public void StartProgram()
        {
            Console.WriteLine("Hurr..Hurr..lirinää..lorinaa..");
        }
    }
}
