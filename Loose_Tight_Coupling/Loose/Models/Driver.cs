using Loose_Tight_Coupling.Loose.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Tight_Coupling.Loose.Models
{
    internal class Driver
    {
        /* Sıkı Bağımlılıkların azaltılması için Interface ve abstract sınıflar kullanılır
         * Böylelikle sınıftan bağımsız birden çok araba kullanabilir
         * Çünkü interfaceler arasında is a ilişkisi vardır yani IAutomobile implement ederse
         * O artık bir IAutomobile'dır.
         */
        //Gevşek Bağımlılık Örneği
        private readonly IAutomobile _automobile;
        public Driver(IAutomobile automobile) { _automobile = automobile; }
        public void InsertTheKey()
        {
            this._automobile.RunTheEngine();
        }
        public void LockAllDoors()
        {
            this._automobile.LockAllDors();
        }
    }
}
