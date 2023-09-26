using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models
{
    internal abstract class Heroe
    {
        public abstract string Name { get; set; }
        public abstract string City { get; set; }

        public abstract string SaveWorld();

        public virtual string SaveCity()
        {
            return $"{Name} ha salvado la ciudad {City}";
        }
    }
}
