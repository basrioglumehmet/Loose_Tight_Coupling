using Loose_Tight_Coupling.Tight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Tight_Coupling.Tight
{
    public class TightExample
    {
        public static void Run()
        {
            Automobile automobile = new Automobile();
            Driver driver = new Driver();
            driver.InsertTheKey();
            driver.LockAllDoors();
        }
    }
}
