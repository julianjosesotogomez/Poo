using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Helpers
{
    internal class Record
    {
        public record SuperHeroRecord(int Id, string Name, string SecretIdentity, string city);
    }
}
