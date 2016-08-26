using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    abstract class Mammal
    {
        public string Name { get; set; }

        public abstract string MakeNoise();
    }
}
