using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MotorCycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Abstract");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("MotorCycle is driving Virtual");
        }

    }
}
