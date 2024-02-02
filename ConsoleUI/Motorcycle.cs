using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"The {GetType().Name} is being ridden.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"The {GetType().Name} is in drive mode, but beware of leaning.");
        }
    }
}
