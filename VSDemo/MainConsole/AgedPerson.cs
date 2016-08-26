using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class AgedPerson : Person
    {
        public AgedPerson() : base(){ }

        public AgedPerson(string firstName, string lastName, int age)
            : base(firstName, lastName)
        {
            Age = age;
        }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} ({Age})";
        }
    }
}
