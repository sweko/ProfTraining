using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}
