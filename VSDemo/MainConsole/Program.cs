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
            Person weko = new Person();
            weko.FirstName = "Wekoslav";
            weko.LastName = "Stefanovski";

            Console.WriteLine(weko);
        }
    }
}
