using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Tight_Coupling.Tight.Models
{
    internal class Automobile
    {
        public void RunTheEngine()
        {
            Console.WriteLine("Engine running");
        }

        public void LockAllDors()
        {
            Console.WriteLine("Locking all doors");
        }
    }
}
