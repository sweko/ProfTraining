using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    public class Person
    {
        static Person()
        {
            count = 100;
        }

        public Person()
        {
            count++;
        }

        public Person(string firstName, string lastName)
        {
            count++;
            FirstName = firstName;
            LastName = lastName;
        }

        static int count;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public static int GetCount()
        {
            return count;
        }
    }
}
