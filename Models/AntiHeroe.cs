using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models
{
    internal class AntiHeroe:SuperHeroe
    {
        public string AntiHeroeAction(string action)
        {
            return $"El AntiHeroe {SecretIdentityName} ha realizado: {action}";
        }
    }
}
