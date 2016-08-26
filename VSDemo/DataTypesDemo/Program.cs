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

            char c = 'a';
            string s = "Wekoslav";

            StringBuilder sb = new StringBuilder(s);

            //if (s[6] == c)
            //{
            //    Console.WriteLine("same");
            //}
            //else
            //{
            //    Console.WriteLine("not-same");
            //}

            for (int i = 0; i < 30000; i++)
            {
                //s += " Stefanovski";
                sb.Append(" Stefanovski");
            }
            Console.WriteLine("done");

        }
    }
}
