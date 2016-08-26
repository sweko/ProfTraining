using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.GetCount());

            Person weko = new Person("Wekoslav", "Stefanovski");

            Console.WriteLine(weko);
            Console.WriteLine(Person.GetCount());

            Person pero = new Person("Petar", "Petrov");

            Console.WriteLine(pero);
            Console.WriteLine(Person.GetCount());

            var empty = new Person();
            Console.WriteLine(Person.GetCount());
        }
    }
}
