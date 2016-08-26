using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = -15;
            //long l = -151515151515151515;
            //short s = -10010;
            //byte b = 30;

            //uint ui = 15;
            //ulong ul = 151515151515151515;
            //ushort us = 10010;

            //int x = 8;
            //bool b = x != 0;

            //char c = 'a';
            //string s = "Wekoslav";

            //StringBuilder sb = new StringBuilder(s);

            //if (s[6] == c)
            //{
            //    Console.WriteLine("same");
            //}
            //else
            //{
            //    Console.WriteLine("not-same");
            //}

            //for (int i = 0; i < 30000; i++)
            //{
            //    //s += " Stefanovski";
            //    sb.Append(" Stefanovski");
            //}
            //Console.WriteLine("done");

            Person p = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Gender = Gender.Male
            };

            switch (p.Gender)
            {
                case Gender.Male:
                    Console.WriteLine(p.FirstName +" is male");
                    break;
                case Gender.Female:
                    Console.WriteLine(p.FirstName + " is female");
                    break;
                case Gender.Unknown:
                    Console.WriteLine(p.FirstName + "'s gender is unknown");
                    break;
                default:
                    throw new InvalidOperationException("gender is invalid");
            }

            Person p2 = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Gender = Gender.Male
            };

            if (p.Equals(p2))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("not-same");
            }

        }
    }
}
