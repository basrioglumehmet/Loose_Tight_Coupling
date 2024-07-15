using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Tight_Coupling.Tight.Models
{
    internal class Driver
    {
        /*
         * Tight Coupling Dezavantajları
         * Sürücü otomobil olmadan bir iş yapamaz
         * Modüler yapı olarak kullanılmak istenirse otomobille birlikte olmak zorunda
         * Otomobil değişiklikleri sürücüyü etkiler
         * Başka tür araç kullanma imkanı verilmez
         * Maliyetlidir.
         */
        //Sıkı bağımlılık örneği
        private readonly Automobile automobile = new Automobile();
        public void InsertTheKey()
        {
            this.automobile.RunTheEngine();
        }
        public void LockAllDoors()
        {
            this.automobile.LockAllDors();
        }
    }
}
