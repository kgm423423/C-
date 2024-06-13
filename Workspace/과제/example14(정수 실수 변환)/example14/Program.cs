using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.14159f;
            int b = (int)a;

            Console.WriteLine(b);

            float c = 123.1f;
            int d = (int)c;
            Console.WriteLine(d);



            int e = 12345;
            float f = e;
            Console.WriteLine(f);

            Console.ReadLine();
        }
    }
}
