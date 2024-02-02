using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    interface IVehicle
    {
        string Year { get; set; }
        string Make { get; set; }
        string Model { get; set; }

        void DriveAbstract();
        void DriveVirtual();
    }
}
