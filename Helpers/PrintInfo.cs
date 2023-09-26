using Poo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Helpers
{
    internal class PrintInfo
    {
        public void PrintSuperHeroe(ISuperHeroe superHeroe) 
        {
            Console.WriteLine($"Id:{superHeroe.Id}");
            Console.WriteLine($"Nombre:{superHeroe.Name}");
            Console.WriteLine($"IdentidadSecreta:{superHeroe.SecretIdentity}");
        }
    }
}
