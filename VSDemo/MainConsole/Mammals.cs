using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class Dog : Mammal
    {
        public override string MakeNoise()
        {
            return "Wow-wow";
        }
    }

    class Cat : Mammal
    {
        public override string MakeNoise()
        {
            return "Meow";
        }
    }

    class Human : Mammal
    {
        public override string MakeNoise()
        {
            return "Bla-bla-bla";
        }
    }
}
