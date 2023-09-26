

namespace Poo.Models
{
    internal class SuperPower
    {
        public string Name;
        public string Description;
        public PowerLevel Level;

        //Construnctor
        public SuperPower()
        {
            Level = PowerLevel.OneLevel;
        }
    }
}
