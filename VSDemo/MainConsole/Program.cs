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
            //abstract examples
            Dog rex = new Dog();
            rex.Name = "Rex";
            Cat fluffy = new Cat();
            fluffy.Name = "Fluffy";
            Mammal weko = new Human();
            weko.Name = "Wekoslav";

            List<Mammal> mammals = new List<Mammal>();
            mammals.Add(rex);
            mammals.Add(fluffy);
            mammals.Add(weko);

            foreach (Mammal mammal in mammals)
            {
                Console.WriteLine("{0} says {1}", 
                    mammal.Name, mammal.MakeNoise());
            }




            //poly-morphism behaviour
            //List<Person> list = new List<Person>();

            //list.Add(new Person("Wekoslav", "Stefanovski"));
            //list.Add(new AgedPerson("Petar", "Petrov", 25));

            //foreach (Person person in list)
            //{
            //    Console.WriteLine(person);
            //}

            //Person p = new AgedPerson("Trajko", "Trajcev", 56);
            //Console.WriteLine(p);

            //Aged Person exercises
            //AgedPerson weko = new AgedPerson();
            //weko.FirstName = "Wekoslav";
            //weko.LastName = "Stefanovski";
            //weko.Age = 0x27;
            //Console.WriteLine(weko);


            //Person class exercises
            //Console.WriteLine(Person.GetCount());

            //Person weko = new Person("Wekoslav", "Stefanovski");

            //Console.WriteLine(weko);
            //Console.WriteLine("{1}, {0}",weko.FirstName, weko.LastName);
            //Console.WriteLine(Person.GetCount());

            //Person pero = new Person("Petar", "Petrov");

            //Console.WriteLine(pero);
            //Console.WriteLine(Person.GetCount());

            //var empty = new Person();
            //Console.WriteLine(Person.GetCount());
        }
    }
}
