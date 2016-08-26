using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    public class Person
    {
        //static constructor
        static Person()
        {
            count = 100;
        }

        //public parameterless constructor
        public Person()
        {
            count++;
        }

        //public constructor
        public Person(string firstName, string lastName)
        {
            count++;
            FirstName = firstName;
            LastName = lastName;
        }

        //static property
        //public static int Count { get; set; }

        //static field
        static int count;

        //public property 
        public string FirstName { get; set; }

        //public property
        public string LastName { get; set; }

        //public method
        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }

        //public static method
        public static int GetCount()
        {
            return count;
        }
    }
}
