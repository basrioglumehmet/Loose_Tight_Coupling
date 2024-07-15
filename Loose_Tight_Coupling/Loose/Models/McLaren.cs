using Loose_Tight_Coupling.Loose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Tight_Coupling.Loose.Models
{
    internal class McLaren : IMcLaren
    {
        public void LockAllDors()
        {
            Console.WriteLine("Mclaren locking mechanisms in operation");
        }

        public void RunTheEngine()
        {
            Console.WriteLine("Mclaren key starter mechanisms in operation");
        }
    }
}
