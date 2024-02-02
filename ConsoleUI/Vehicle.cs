using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle : IVehicle
    {
        public string Year { get; set; } = "Generic";
        public string Make { get; set; } = "Generic";
        public string Model { get; set; } = "Generic";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The {GetType().Name} is in drive mode.");
        }
    }
}
