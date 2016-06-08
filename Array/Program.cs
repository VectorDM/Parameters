using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "H,U.G;U[I/";
            string[] result = str.Split(',', '.', ';', '[', '/');
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

        }
    }

}
