
using Loose_Tight_Coupling.Loose.Interfaces;
using Loose_Tight_Coupling.Loose.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Tight_Coupling.Loose
{
    public class LooseExample
    {
        public static void Run()
        {
            Audi audi = new Audi();
            McLaren mcLaren = new McLaren();
            Driver driver = new Driver(audi);
            Driver driver2 = new Driver(mcLaren);
            driver.InsertTheKey();
            driver.LockAllDoors();
            driver2.LockAllDoors();
            driver2.InsertTheKey();
        }
    }
}
