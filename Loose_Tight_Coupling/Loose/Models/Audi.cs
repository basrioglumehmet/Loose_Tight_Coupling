using Loose_Tight_Coupling.Loose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Tight_Coupling.Loose.Models
{
    internal class Audi : IAudi
    {
        public void LockAllDors()
        {
            Console.WriteLine("Audi locking mechanisms in operation");
        }

        public void RunTheEngine()
        {
            Console.WriteLine("Audi key starter mechanisms in operation");
        }
    }
}
