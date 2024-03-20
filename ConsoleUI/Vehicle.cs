using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2014";
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() { Console.WriteLine("Virtual"); }

    }
}
